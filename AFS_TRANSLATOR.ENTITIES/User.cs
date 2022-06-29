using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace AFS_TRANSLATOR.ENTITIES
{
    public class User:IdentityUser
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
