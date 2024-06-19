namespace DynamicApplication.Models.DTOs
{
    public class FormResponseDTO
    {
        public Guid TemplateId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string? Phone { get; set; }
        public string? Nationality { get; set; }
        public string? CurrentResidence { get; set; }
        public string? IDNumber { get; set; }
        public DateOnly? DateOfBirth { get; set; }
        public string? Gender { get; set; }
        public List<ParagraphAnswerDTO>? ParagraphAnswers { get; set; }
        public List<YesOrNoAnswerDTO>? YesOrNoAnswers { get; set; }
        public List<DropdownAnswerDTO>? DropdownAnswers { get; set; }
        public List<MultichoiceAnswerDTO>? MultichoiceAnswers { get; set; }
        public List<NumericAnswerDTO>? NumericAnswers { get; set; }
        public List<DateAnswerDTO>? DateAnswers { get; set; }
    }
}
