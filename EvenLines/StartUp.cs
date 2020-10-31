using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace EvenLines
{
    class StartUp
    {
        static void Main()
        {
            var pattern = new Regex(@"[-\.,!?]");
            
            using var reader = new StreamReader("../../../text.txt");
            using var writer = new StreamWriter("../../../output.txt");
            
            var line = reader.ReadLine();
            var lineCounter = 0;

            while (line != null)
            {
                if (lineCounter % 2 == 0)
                {
                    line = pattern.Replace(line, "@");
                    var arr = line.Split().ToArray().Reverse();
                    writer.WriteLine(string.Join(" ", arr));
                }

                lineCounter++;
                line = reader.ReadLine();
            }
        }
    }
}
