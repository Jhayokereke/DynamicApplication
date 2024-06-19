namespace DynamicApplication.Models.DTOs
{
    public record DateQuestionDTO(string Value, int QuestionNumber);
    public record NumericQuestionDTO(string Value, int QuestionNumber);
    public record DropdownQuestionDTO(string Value, List<string> Options, int QuestionNumber);
    public record MultichoiceQuestionDTO(string Value, List<string> Options, int MaxAllowed, int QuestionNumber);
    public record YesOrNoQuestionDTO(string Value, int QuestionNumber);
    public record ParagraphQuestionDTO(string Value, int QuestionNumber);
    public record FieldDTO(bool IsInternal, bool Hide);

    public record DateAnswerDTO(Guid QuestionId, DateOnly Value);
    public record ParagraphAnswerDTO(Guid QuestionId, string Value);
    public record DropdownAnswerDTO(Guid QuestionId, string Value);
    public record NumericAnswerDTO(Guid QuestionId, decimal Value);
    public record YesOrNoAnswerDTO(Guid QuestionId, string Value);
    public record MultichoiceAnswerDTO(Guid QuestionId, List<string> Value);
}
