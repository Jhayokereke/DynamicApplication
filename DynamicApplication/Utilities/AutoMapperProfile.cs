using AutoMapper;
using DynamicApplication.Models.DTOs;
using DynamicApplication.Models.Entities;

namespace DynamicApplication.Utilities
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<CreateFormFieldsDTO, FormTemplate>().ReverseMap();
            CreateMap<EditFormFieldsDTO, FormTemplate>().ReverseMap();
            CreateMap<FormTemplate, FormFieldsDTO>();
            CreateMap<MultichoiceQuestionDTO, MultichoiceQuestion>()
                .AfterMap((_, dst) => { if (dst.MaxAllowed > dst.Options.Count) dst.MaxAllowed = dst.Options.Count; })
                .ReverseMap();
            CreateMap<MultichoiceAnswerDTO, MultichoiceAnswer>().ReverseMap();
            CreateMap<DropdownQuestionDTO, DropdownQuestion>().ReverseMap();
            CreateMap<DropdownAnswerDTO, DropdownAnswer>().ReverseMap();
            CreateMap<ParagraphQuestionDTO, ParagraphQuestion>().ReverseMap();
            CreateMap<ParagraphAnswerDTO, ParagraphAnswer>().ReverseMap();
            CreateMap<DateQuestionDTO, DateQuestion>().ReverseMap();
            CreateMap<DateAnswerDTO, DateAnswer>().ReverseMap();
            CreateMap<YesOrNoQuestionDTO, YesOrNoQuestion>().ReverseMap();
            CreateMap<YesOrNoAnswerDTO, YesOrNoAnswer>().ReverseMap();
            CreateMap<NumericQuestionDTO, NumericQuestion>().ReverseMap();
            CreateMap<NumericAnswerDTO, NumericAnswer>().ReverseMap();
            CreateMap<FieldDTO, Field>().ReverseMap();
            CreateMap<FormResponseDTO, FormResponse>();
        }
    }
}
