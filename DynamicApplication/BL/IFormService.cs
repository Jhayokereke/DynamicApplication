using DynamicApplication.Models.DTOs;

namespace DynamicApplication.BL
{
    public interface IFormService
    {
        ApiResponse<Guid> CreateFormTemplate(CreateFormFieldsDTO model);
        ApiResponse EditFormTemplate(EditFormFieldsDTO model);
        ApiResponse<FormFieldsDTO> GetFormTemplate(Guid templateId);
        ApiResponse SubmitForm(FormResponseDTO form);
    }
}
