using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace docsort
{
    public class Correspondent
    {
        public string Name { get; set; }
        public string SavePath { get; set; }

        // Semicolon separated
        public string DetectRegex { get; set; }

        public bool MatchesText(string text)
        {
            var regex = new Regex(DetectRegex);
            return regex.IsMatch(text);
        }

        public override string ToString()
        {
            return Name;
        }
    }
}