using System.ComponentModel.DataAnnotations;

namespace Democracy.Domain
{
    public class PollQuestionOption
    {
        [Key]
        public Poll Poll { get; set; }
        [Key]
        public QuestionOption Question { get; set; }
        [Key]
        public int Index { get; set; }
        public string ContentUrl { get; set; }
    }
}
