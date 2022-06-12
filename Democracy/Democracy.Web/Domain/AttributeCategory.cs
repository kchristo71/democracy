using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Democracy.Web.Domain
{
    public class AttributeCategory
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = string.Empty;
        public string Descrption { get; set; } = string.Empty;
        [JsonIgnore]
        public AttributeCategory? Parent {get; set;}
        [NotMapped]
        public Guid? ParentCategoryId => Parent?.Id;
    }
}