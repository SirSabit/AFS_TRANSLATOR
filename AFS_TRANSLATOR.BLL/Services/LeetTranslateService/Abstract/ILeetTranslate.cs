using AFS_TRANSLATOR.DTO.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFS_TRANSLATOR.BLL.Services.LeetTranslateService.Abstract
{
    public interface ILeetTranslate
    {
        void TranslateToLeet(LeetTranslateRequestDTO request);
    }
}
