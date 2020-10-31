using System.IO;
using System.Linq;

namespace LineNumbers
{
    class StartUp
    {
        static void Main()
        {
            var lines = File.ReadAllLines("../../../text.txt");

            for (var i = 0; i < lines.Length; i++)
            {
                var line = lines[i];
                var letters = CountOfLetters(line);
                var punctuationMarks = CountOfPunctuationMarks(line);

                lines[i] = $"Line {i} {lines[i]}({letters})({punctuationMarks})";
            }

            File.WriteAllLines("../../../output.txt", lines);
        }

        private static int CountOfLetters(string text) => text.Count(char.IsLetter);
        
        private static int CountOfPunctuationMarks(string text) => text.Count(char.IsPunctuation);
    }
}
