using DynamicApplication.Models.Helpers;

namespace DynamicApplication.Models.Entities
{
    public class DateQuestion : Question
    {
        public override QuestionType Type { get; } = QuestionType.Date;
    }

    public class DateAnswer : Answer
    {
        public new DateOnly Value { get; set; }
    }
}
