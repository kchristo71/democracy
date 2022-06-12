using System.ComponentModel.DataAnnotations;

namespace Democracy.Web.Domain
{
    public class PollAttributeValue
    {
        [Key]
        public Guid Id { get; set; }
        public Poll Poll { get; set; }
        public AttributeValue AttributeValue { get; set; }
    }
}
