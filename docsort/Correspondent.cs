using System.Collections.Generic;

namespace docsort
{
    public class Correspondent
    {
        public string Name { get; set; }
        public string SavePath { get; set; }

        // Semicolon separated
        public string DetectPatterns { get; set; }

        public bool MatchesText(string text)
        {
            var detectPatternList = DetectPatterns.Split(';');
            foreach (var pattern in detectPatternList)
            {
                if (text.ToLower().Contains(pattern.ToLower()))
                {
                    return true;
                }
            }

            return false;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}