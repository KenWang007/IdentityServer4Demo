using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc; 

namespace Inventory.Controllers
{
    [Route("[controller]")]
    [Authorize]
    public class InventoryController : ControllerBase
    {
        // GET api/Inventory
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
                Description = "Access user inventory api successfully" + DateTime.Now.Second,
                UserIdentitys = userIdentitys.ToList()
            };

            return new JsonResult(result);
        }
    }
}
