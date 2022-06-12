using System.ComponentModel.DataAnnotations;

namespace Democracy.Web.Domain
{
    public class PollType
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
    }
}
