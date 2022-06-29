using AFS_TRANSLATOR.CORE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFS_TRANSLATOR.ENTITIES
{
    public class User:CoreEntity
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
