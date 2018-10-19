using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Product;

namespace Api.Controllers
{
    [Route("[controller]")]
    [Authorize]
    public class ProductController : ControllerBase
    {
        // GET api/product
        [HttpGet]
        public IActionResult Get()
        {
            var userIdentitys = from c in User.Claims
                                select new UserIdentity
                                {
                                    Type = c.Type,
                                    Value = c.Value
                                };
            var result = new UserIdentityModel()
            {
                Description = "Access user product api successfully",
                UserIdentitys = userIdentitys.ToList()
            };

            return new JsonResult(result);
        }
    }
}
