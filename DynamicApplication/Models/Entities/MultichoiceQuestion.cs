using DynamicApplication.Models.Helpers;

namespace DynamicApplication.Models.Entities
{
    public class MultichoiceQuestion : Question
    {
        public override QuestionType Type { get; } = QuestionType.Multichoice;
        public List<string> Options { get; set; }
        public int MaxAllowed { get; set; }
    }

    public class MultichoiceAnswer : Answer
    {
        public new List<string> Value { get; set; }
    }
}
