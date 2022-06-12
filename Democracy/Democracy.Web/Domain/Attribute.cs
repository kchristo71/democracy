using System.ComponentModel.DataAnnotations;

namespace Democracy.Web.Domain
{
    public class Attribute
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = string.Empty;
        public AttributeCategory Category { get; set; }
    }
}
