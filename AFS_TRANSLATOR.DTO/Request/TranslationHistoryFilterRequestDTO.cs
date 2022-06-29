﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFS_TRANSLATOR.DTO.Request
{
    public  class TranslationHistoryFilterRequestDTO
    {
        public int Id { get; set; }
        public DateTime MinDate { get; set; } = DateTime.MinValue;
        public DateTime MaxDate { get; set; } = DateTime.MaxValue;
        public string Text { get; set; } = "";
        public string TranslationType { get; set; } = "";
        public string Translation { get; set; } = "";
    }
}
