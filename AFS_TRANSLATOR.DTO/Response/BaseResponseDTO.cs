using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFS_TRANSLATOR.DTO.Response
{
    public class BaseResponseDTO
    {
        public int StatusCode { get; set; }
        public string Message { get; set; }       
    }
}
