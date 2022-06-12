using Democracy.Web.Domain;
using Democracy.Web.Requests;

namespace Democracy.Web.Services
{
    public interface IPollsManager
    {
        public IEnumerable<AttributeCategory> AttributeCategories();
        public Guid? CreateOrUpdate(AttributeCategoryRequest attributeCategoryRequest);
    }
}
