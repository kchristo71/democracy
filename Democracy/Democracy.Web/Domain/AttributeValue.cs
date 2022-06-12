using System.ComponentModel.DataAnnotations;

namespace Democracy.Web.Domain
{
    public class AttributeValue
    {
        [Key]
        public Guid Id { get; set; }
        public Attribute Attribute { get; set; }
        public string Value { get; set; }
    }
}
