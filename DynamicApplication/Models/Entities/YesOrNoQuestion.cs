using DynamicApplication.Models.Helpers;

namespace DynamicApplication.Models.Entities
{
    public class YesOrNoQuestion : Question
    {
        public override QuestionType Type { get; } = QuestionType.YesOrNo;
    }

    public class YesOrNoAnswer : Answer
    {
    }
}
