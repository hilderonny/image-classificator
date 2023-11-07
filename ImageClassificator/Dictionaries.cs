using System.Collections.Generic;

namespace ImageClassificator
{
    internal class Dictionaries
    {
        public static Dictionary<string, string> Languages { get; } = new()
        {
            { "de", "Deutsch" },
            { "en", "English" }
        };

    }
}
