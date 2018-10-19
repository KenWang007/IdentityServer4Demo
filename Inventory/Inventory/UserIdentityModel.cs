using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inventory
{
    public class UserIdentityModel
    {
        public string Description { get; set; }

        public List<UserIdentity> UserIdentitys { get; set; }
    }

    public class UserIdentity
    {
        public string Type { get; set; }

        public string Value { get; set; }
    }
}
