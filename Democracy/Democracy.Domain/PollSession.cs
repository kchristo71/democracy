using System.ComponentModel.DataAnnotations;

namespace Democracy.Domain
{
    public class PollSession
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        public Poll Poll { get; set; }
        public DateTimeOffset SessionStarted { get; set; } = DateTimeOffset.UtcNow;
        public DateTimeOffset? SessionFinished { get; set; }
    }
}
