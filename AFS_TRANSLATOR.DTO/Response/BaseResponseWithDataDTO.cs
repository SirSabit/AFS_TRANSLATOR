using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFS_TRANSLATOR.DTO.Response
{
    public class BaseResponseWithDataDTO<T>:BaseResponseDTO
    {
        public T Data { get; set; }
    }
}
