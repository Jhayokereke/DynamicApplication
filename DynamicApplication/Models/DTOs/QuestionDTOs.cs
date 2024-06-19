namespace DynamicApplication.Models.DTOs
{
    public record DateQuestionDTO(string Value, int QuestionNumber);
    public record NumericQuestionDTO(string Value, int QuestionNumber);
    public record DropdownQuestionDTO(string Value, List<string> Options, int QuestionNumber);
    public record MultichoiceQuestionDTO(string Value, List<string> Options, int MaxAllowed, int QuestionNumber);
    public record YesOrNoQuestionDTO(string Value, int QuestionNumber);
    public record ParagraphQuestionDTO(string Value, int QuestionNumber);
    public record FieldDTO(bool IsInternal, bool Hide);

    public record DateAnswerDTO(int QuestionNumber, DateOnly Value);
    public record ParagraphAnswerDTO(int QuestionNumber, string Value);
    public record DropdownAnswerDTO(int QuestionNumber, string Value);
    public record NumericAnswerDTO(int QuestionNumber, decimal Value);
    public record YesOrNoAnswerDTO(int QuestionNumber, string Value);
    public record MultichoiceAnswerDTO(int QuestionNumber, List<string> Value);
}
