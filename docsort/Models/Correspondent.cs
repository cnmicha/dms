using System.Text.RegularExpressions;

namespace docsort.Models
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

        public Correspondent Clone()
        {
            return new Correspondent()
            {
                Name = this.Name,
                SavePath = this.SavePath,
                DetectRegex = this.DetectRegex
            };
        }
    }
}