using DynamicApplication.Models.Helpers;

namespace DynamicApplication.Models.Entities
{
    public class NumericQuestion : Question
    {
        public override QuestionType Type { get; } = QuestionType.Numeric;
    }

    public class NumericAnswer : Answer
    {
        public new decimal Value { get; set; }
    }
}
