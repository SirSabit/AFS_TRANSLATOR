using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFS_TRANSLATOR.DTO.Response
{
    public class HistoryTranslationDTO
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Text { get; set; } = "";
        public string Translation { get; set; } = "";
        public string TranslationType { get; set; } = "";
    }
}
