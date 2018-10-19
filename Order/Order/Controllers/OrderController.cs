using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Order.Controllers
{
    [Route("[controller]")]
    [Authorize]
    public class OrderController : ControllerBase
    {
        // GET api/order
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
                Description = "Access user order api successfully",
                UserIdentitys = userIdentitys.ToList()
            };

            return new JsonResult(result);
        }
    }
}
