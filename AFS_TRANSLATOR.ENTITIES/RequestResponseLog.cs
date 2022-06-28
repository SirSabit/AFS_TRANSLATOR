using AFS_TRANSLATOR.CORE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFS_TRANSLATOR.ENTITIES
{
    public class RequestResponseLog:CoreEntity
    {        
        public string RequestHeader { get; set; } = "";
        public string RequestBody { get; set; } = "";
        public string Response { get; set; } = "";
    }
}
