using System.ComponentModel.DataAnnotations;

namespace Democracy.Web.Domain
{
    public class QuestionOption
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        public Question Question { get; set; }
        public int Index { get; set; }
        public string? ContentUrl { get; set; }
    }
}
