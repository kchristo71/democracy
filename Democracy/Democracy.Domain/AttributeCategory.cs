using System.ComponentModel.DataAnnotations;

namespace Democracy.Domain
{
    public class AttributeCategory
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = string.Empty;
        public string Descrption { get; set; } = string.Empty;
        public IEnumerable<AttributeCategory> Related { get; set; } = Array.Empty<AttributeCategory>();
    }
}