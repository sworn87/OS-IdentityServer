using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Ivysoft.OnlineSystem.API.Controllers
{
    public class IdentityController : ControllerBase
    {
        [Route("[controller]")]
        [Authorize]
        [HttpGet]
        public IActionResult Get()
        {
            return new JsonResult(from c in User.Claims select new { c.Type, c.Value });
        }
    }
}
