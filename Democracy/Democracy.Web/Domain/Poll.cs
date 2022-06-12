using System.ComponentModel.DataAnnotations;

namespace Democracy.Web.Domain
{
    public class Poll
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty; 
        public IEnumerable<PollAttributeValue> AttributeValues { get; set; }
        public PollCategory Category { get; set; }
        public PollType Type { get; set; }
        public bool LiveResults { get; set; } = false;
        public bool LiveParticipants { get; set; } = false;
        public DateTimeOffset? StartDate { get; set; }
        public DateTimeOffset? EndDate { get; set; }
        public DateTimeOffset CreationDate { get; set; } = DateTimeOffset.UtcNow;
        public IEnumerable<PollQuestion> Questions { get; set; }
    }
}
