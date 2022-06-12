using Democracy.Web.Data;
using Democracy.Web.Domain;
using Democracy.Web.Requests;
using Microsoft.EntityFrameworkCore;

namespace Democracy.Web.Services
{
    public class PollsManager : IPollsManager
    {
        public PollsContext PollsContext { get; }
        public PollsManager(PollsContext pollsContext)
        {
            PollsContext = pollsContext;
        }

        public Guid? CreateOrUpdate(AttributeCategoryRequest attributeCategoryRequest)
        {
            AttributeCategory attributeCategory;
            Action<AttributeCategory> crudAction;
            if (attributeCategoryRequest.Id == null || attributeCategoryRequest.Id.Value.Equals(Guid.Empty))
            {
                attributeCategory = new AttributeCategory();
                crudAction = (category) => PollsContext.AttributeCategories.Add(attributeCategory);
            }
            else
            {
                attributeCategory = PollsContext.AttributeCategories.SingleOrDefault(c => c.Id.Equals(attributeCategoryRequest.Id.Value));
                if (attributeCategory == null)
                {
                    return null;
                }
                crudAction = (category) => PollsContext.AttributeCategories.Update(attributeCategory);
            }
            attributeCategory.Descrption = attributeCategoryRequest.Description;
            attributeCategory.Name = attributeCategoryRequest.Name;
            attributeCategory.Parent = attributeCategoryRequest.ParentCategoryId == null
                ? null
                : AttributeCategories().Single(c => c.Id.Equals(attributeCategoryRequest.ParentCategoryId));
            crudAction(attributeCategory);
            PollsContext.SaveChanges();
            return attributeCategory.Id;
        }

        public IEnumerable<AttributeCategory> AttributeCategories()
        {
            return PollsContext.AttributeCategories.Include(c => c.Parent);
        }
    }
}
