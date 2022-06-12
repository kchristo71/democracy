using System.ComponentModel.DataAnnotations;

namespace Democracy.Web.Domain
{
    public class PollSession
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid? UserId { get; set; }
        public string? FullName { get; set; }
        public Poll Poll { get; set; }
        public DateTimeOffset SessionStarted { get; set; } = DateTimeOffset.UtcNow;
        public DateTimeOffset? SessionFinished { get; set; }
    }
}
