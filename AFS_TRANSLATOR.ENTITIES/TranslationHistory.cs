using AFS_TRANSLATOR.CORE;

namespace AFS_TRANSLATOR.ENTITIES
{
    public class TranslationHistory : CoreEntity
    {
        public string Text { get; set; } = "";
        public string Translation { get; set; } = "";
        public string TranslationType { get; set; } = "";
    }
}
