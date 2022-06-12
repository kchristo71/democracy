using System.ComponentModel.DataAnnotations;

namespace Democracy.Web.Domain
{
    public class PollSessionQuestionAnswer
    {
        [Key]
        public PollSession PollSession { get; set; }
        [Key]
        public PollQuestion PollQuestion { get; set; }
        public string PollQuestionAnswer { get; set; }
    }
}
