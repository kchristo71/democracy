using System.ComponentModel.DataAnnotations;

namespace Democracy.Domain
{
    public class PollQuestion
    {
        [Key]
        public Question Question { get; set; }
        public IEnumerable<PollQuestionOption> QuestionOptions { get; set; }
        public string? ContentUrl { get; set; }
        public int Index { get; set; }
        public string Condition { get; set; }
        public int? Min { get; set; }
        public int? Max { get; set; }
    }
}
