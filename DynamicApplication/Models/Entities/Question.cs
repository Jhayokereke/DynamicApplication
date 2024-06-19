using DynamicApplication.Models.Helpers;

namespace DynamicApplication.Models.Entities
{
    public class Question
    {
        public virtual QuestionType Type { get; }
        public string Value { get; set; }
        public int QuestionNumber { get; set; }
    }

    public class Answer
    {
        public int QuestionNumber { get; set; }
        public string Value { get; set; }
    }
}
