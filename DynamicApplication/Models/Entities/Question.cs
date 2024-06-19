using DynamicApplication.Models.Helpers;

namespace DynamicApplication.Models.Entities
{
    public class Question
    {
        public Guid Id { get; set; }
        public virtual QuestionType Type { get; }
        public string Value { get; set; }
        public int QuestionNumber { get; set; }
    }

    public class Answer
    {
        public Guid QuestionId { get; set; }
        public string Value { get; set; }
    }
}
