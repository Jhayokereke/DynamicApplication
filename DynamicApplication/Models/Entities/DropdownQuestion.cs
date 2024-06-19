using DynamicApplication.Models.Helpers;

namespace DynamicApplication.Models.Entities
{
    public class DropdownQuestion : Question
    {
        public override QuestionType Type { get; } = QuestionType.Dropdown;
        public List<string> Options { get; set; }
    }

    public class DropdownAnswer : Answer
    {
    }
}
