﻿using AFS_TRANSLATOR.CORE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFS_TRANSLATOR.ENTITIES
{
    public class TranslationHistory:CoreEntity
    {        
        public string Text { get; set; } = "";
        public string Translation { get; set; } = "";
        public string TranslationType { get; set; } = "";
    }
}