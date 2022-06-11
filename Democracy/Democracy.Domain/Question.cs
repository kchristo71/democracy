using System.ComponentModel.DataAnnotations;

namespace Democracy.Domain
{
    public class Question
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        public QuestionType QuestionType { get; set; } = QuestionType.FreeText;
        public string Text { get; set; } = string.Empty;
        public string? ContentUrl { get; set; }
    }
}
