using System.ComponentModel.DataAnnotations;

namespace Democracy.Domain
{
    public abstract class AttributeValue
    {
        [Key]
        public Attribute Attribute { get; set; }
        [Key]
        public string Value { get; set; }
    }
}
