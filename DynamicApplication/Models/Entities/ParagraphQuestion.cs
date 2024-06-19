using DynamicApplication.Models.Helpers;

namespace DynamicApplication.Models.Entities
{
    public class ParagraphQuestion : Question
    {
        public override QuestionType Type { get; } = QuestionType.Paragraph;
    }

    public class ParagraphAnswer : Answer
    {
        public string Value { get; set; }
    }
}
