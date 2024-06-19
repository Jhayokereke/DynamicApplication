using AutoMapper;
using DynamicApplication.Models.DTOs;
using DynamicApplication.Models.Entities;
using Microsoft.Azure.Cosmos;
using System.Net;

namespace DynamicApplication.BL
{
    public class FormService : IFormService
    {
        private readonly CosmosClient _client;
        private readonly Database _database;
        private readonly Container _templateContainer;
        private readonly Container _responseContainer;
        private readonly IMapper _mapper;

        public FormService(CosmosClient client, IMapper mapper)
        {
            string _dbName = "DynamicApplication";
            string _templateContainerName = "FormTemplate";
            string _reponseContainerName = "FormResponse";
            _client = client;
            _database = _client.CreateDatabaseIfNotExistsAsync(_dbName).GetAwaiter().GetResult();
            _templateContainer = _database.CreateContainerIfNotExistsAsync(_templateContainerName, "/id").GetAwaiter().GetResult();
            _responseContainer = _database.CreateContainerIfNotExistsAsync(_reponseContainerName, "/firstName").GetAwaiter().GetResult();
            _mapper = mapper;
        }

        public ApiResponse<Guid> CreateFormTemplate(CreateFormFieldsDTO model)
        {
            var newEntry = _mapper.Map<FormTemplate>(model);
            newEntry.Id = Guid.NewGuid();
            newEntry.CreatedOn = DateTime.Now;

            var result = _templateContainer.UpsertItemAsync(newEntry).GetAwaiter().GetResult();

            if (result.StatusCode != HttpStatusCode.Created) return new ApiResponse<Guid>() { Message = "Operation failed!", Status = false };

            return new ApiResponse<Guid>(){ Data = result.Resource.Id, Message = "Successful", Status = true };
        }

        public ApiResponse EditFormTemplate(EditFormFieldsDTO model)
        {
            var existing = _templateContainer.ReadItemAsync<FormTemplate>(model.Id, new PartitionKey(model.Id)).GetAwaiter().GetResult();
            if (existing.StatusCode != HttpStatusCode.OK) return new ApiResponse() { Message = $"No existing Template with this id: {model.Id}", Status = false };

            var updatedEntry = _mapper.Map<FormTemplate>(model);
            updatedEntry.ModifiedOn = DateTime.Now;
            updatedEntry.CreatedOn = existing.Resource.CreatedOn;

            var result = _templateContainer.UpsertItemAsync(updatedEntry).GetAwaiter().GetResult();

            if (result.StatusCode != HttpStatusCode.OK) return new ApiResponse() { Message = "Operation failed!", Status = false };

            return new ApiResponse() { Message = "Successful", Status = true };
        }

        public ApiResponse<FormFieldsDTO> GetFormTemplate(Guid templateId)
        {
            var result = _templateContainer.ReadItemAsync<FormTemplate>(templateId.ToString("D"), new PartitionKey(templateId.ToString("D"))).GetAwaiter().GetResult();

            if (result.StatusCode != HttpStatusCode.OK) return new ApiResponse<FormFieldsDTO>() { Message = "Operation failed!", Status = false };

            var data = _mapper.Map<FormFieldsDTO>(result.Resource);

            return new ApiResponse<FormFieldsDTO>() { Data = data, Message = "Successful", Status = true };
        }

        public ApiResponse SubmitForm(FormResponseDTO form)
        {
            var newEntry = _mapper.Map<FormResponse>(form);
            newEntry.Id = Guid.NewGuid();
            newEntry.CreatedOn = DateTime.Now;

            var template = _templateContainer.ReadItemAsync<FormTemplate>(form.TemplateId.ToString("D"), new PartitionKey(form.TemplateId.ToString("D"))).GetAwaiter().GetResult();
            if (template.StatusCode != HttpStatusCode.OK) return new ApiResponse() { Message = $"No existing Template with this id: {form.TemplateId}", Status = false };

            var result = _responseContainer.UpsertItemAsync(newEntry).GetAwaiter().GetResult();

            if (result.StatusCode != HttpStatusCode.Created) return new ApiResponse() { Message = "Operation failed!", Status = false };

            return new ApiResponse<Guid>() { Data = result.Resource.Id, Message = "Successful", Status = true };
        }
    }
}
