using Microsoft.AspNetCore.Mvc;

namespace Democracy.Web.Controllers
{
    [ApiController]
    public abstract class ApiControllerBase<T> : ControllerBase
        where T : ApiControllerBase<T>
    {
        protected ApiControllerBase()
        {
        }
    }
}
