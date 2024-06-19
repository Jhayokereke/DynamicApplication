namespace DynamicApplication.Models.DTOs
{
    public class EditFormFieldsDTO
    {
        public string Id { get; set; }
        public string ProgramTitle { get; set; }
        public string ProgramDescription { get; set; }
        public FieldDTO Phone { get; set; }
        public FieldDTO Nationality { get; set; }
        public FieldDTO CurrentResidence { get; set; }
        public FieldDTO IDNumber { get; set; }
        public FieldDTO DateOfBirth { get; set; }
        public FieldDTO Gender { get; set; }
        public List<ParagraphQuestionDTO>? ParagraphQuestions { get; set; }
        public List<YesOrNoQuestionDTO>? YesOrNoQuestions { get; set; }
        public List<DropdownQuestionDTO>? DropdownQuestions { get; set; }
        public List<MultichoiceQuestionDTO>? MultichoiceQuestions { get; set; }
        public List<NumericQuestionDTO>? NumericQuestions { get; set; }
        public List<DateQuestionDTO>? DateQuestions { get; set; }
    }
}
