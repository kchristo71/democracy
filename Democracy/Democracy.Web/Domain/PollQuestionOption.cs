using System.ComponentModel.DataAnnotations;

namespace Democracy.Web.Domain
{
    public class PollQuestionOption
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        public Poll Poll { get; set; }
        public QuestionOption QuestionOption { get; set; }
        public int Index { get; set; }
        public string? ContentUrl { get; set; }
    }
}
