namespace DynamicApplication.Models.Entities
{
    public class FormTemplate : BaseEntity
    {
        public string ProgramTitle { get; set; }
        public string ProgramDescription { get; set; }
        public Field Phone { get; set; }
        public Field Nationality { get; set; }
        public Field CurrentResidence { get; set; }
        public Field IDNumber { get; set; }
        public Field DateOfBirth { get; set; }
        public Field Gender { get; set; }
        public List<ParagraphQuestion>? ParagraphQuestions { get; set; }
        public List<YesOrNoQuestion>? YesOrNoQuestions { get; set; }
        public List<DropdownQuestion>? DropdownQuestions { get; set; }
        public List<MultichoiceQuestion>? MultichoiceQuestions { get; set; }
        public List<NumericQuestion>? NumericQuestions { get; set; }
        public List<DateQuestion>? DateQuestions { get; set; }
    }
}
