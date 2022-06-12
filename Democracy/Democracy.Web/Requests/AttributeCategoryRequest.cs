using System.ComponentModel.DataAnnotations;

namespace Democracy.Web.Requests
{
    public class AttributeCategoryRequest
    {
        public Guid? Id { get; set; } = Guid.Empty;
        [Required(AllowEmptyStrings = false)]
        public string? Name { get; set; }
        public string? Description { get; set; }
        public Guid? ParentCategoryId { get; set; }
    }
}
