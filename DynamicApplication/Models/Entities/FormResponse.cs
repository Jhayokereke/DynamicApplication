namespace DynamicApplication.Models.Entities
{
    public class FormResponse : BaseEntity
    {
        public Guid TemplateId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Nationality { get; set; }
        public string CurrentResidence { get; set; }
        public string IDNumber { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public string Gender { get; set; }
        public List<ParagraphAnswer> ParagraphAnswers { get; set; }
        public List<YesOrNoAnswer> YesOrNoAnswers { get; set; }
        public List<DropdownAnswer> DropdownAnswers { get; set; }
        public List<MultichoiceAnswer> MultichoiceAnswers { get; set; }
        public List<NumericAnswer> NumericAnswers { get; set; }
        public List<DateAnswer> DateAnswers { get; set; }
    }
}
