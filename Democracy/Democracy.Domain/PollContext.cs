using Microsoft.EntityFrameworkCore;

namespace Democracy.Domain
{
    public class PollContext: DbContext
    {
        public DbSet<AttributeCategory> AttributeCategories { get; set; }
        public DbSet<Attribute> Attributes { get; set; }
        public DbSet<PollAttributeValue> PollAttributeValues { get; set; }
        public DbSet<PollCategory> PollCategories { get; set; }
        public DbSet<PollType> PollTypes { get; set; }
        public DbSet<Poll> Polls { get; set; }
        public DbSet<PollSession> PollSessions { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<QuestionOption> QuestionOptions { get; set; }
    }
}
