using System.ComponentModel.DataAnnotations;

namespace Democracy.Web.Domain
{
    public class PollCategory
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string? Description { get; set;}
    }
}
