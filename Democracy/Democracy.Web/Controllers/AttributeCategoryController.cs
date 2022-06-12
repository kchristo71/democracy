using Democracy.Web.Domain;
using Democracy.Web.Requests;
using Democracy.Web.Services;
using Microsoft.AspNetCore.Mvc;

namespace Democracy.Web.Controllers
{
    [Route("api/[controller]")]
    public class AttributeCategoryController : ApiControllerBase<AttributeCategoryController>
    {
        public IPollsManager PollsManager { get; }
        public AttributeCategoryController(IPollsManager pollsManager)
        {
            PollsManager = pollsManager;
        }
        [HttpGet]
        public ActionResult<IEnumerable<AttributeCategory>> Get()
        {
            return new ObjectResult(PollsManager.AttributeCategories());
        }
        [HttpPut]
        public IActionResult CreateOrUpdateAttributeCategory([FromBody] AttributeCategoryRequest attributeCategoryRequest)
        {
            try
            {
                var id = PollsManager.CreateOrUpdate(attributeCategoryRequest);
                if (id == null)
                {
                    return NotFound();
                }
                return attributeCategoryRequest.Id == null || attributeCategoryRequest.Id.Value.Equals(Guid.Empty)
                    ? Created(string.Empty, id)
                    : Accepted(string.Empty, id);
            }
            catch(Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
