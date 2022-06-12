using System.ComponentModel.DataAnnotations;

namespace Democracy.Web.Domain
{
    public class PollQuestion
    {
        [Key]
        public Guid Id { get; set; }
        public Question Question { get; set; }
        public Poll Poll { get; set; }
        public IEnumerable<PollQuestionOption> QuestionOptions { get; set; }
        public string? ContentUrl { get; set; }
        public int Index { get; set; }
        public string Condition { get; set; }
        public int? Min { get; set; }
        public int? Max { get; set; }
    }
}
