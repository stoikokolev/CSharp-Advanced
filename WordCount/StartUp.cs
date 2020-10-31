using System;
using System.IO;
using System.Linq;

namespace WordCount
{
    class StartUp
    {
        static void Main()
        {
            var lines = File.ReadAllLines("../../../text.txt");
            var words = File.ReadAllLines("../../../words.txt");
            
            var pattern = new[]{'.',',','!','?','-'};
            
            var dict= words.ToDictionary(word => word, word => 0);
            
            foreach (var line in lines)
            {
                var textArr = line.Split(pattern).ToArray();
                
                foreach (var word in textArr)
                {
                    if (dict.ContainsKey(word))
                    {
                        dict[word]++;
                    }

                }

            }

            foreach (var text in dict
                .Select(element => $"{element.Key} - {element.Value}{Environment.NewLine}"))
            {
                File.AppendAllText("../../../actualResult.txt",text);
            }

            foreach (var text in dict
                .OrderByDescending(x=>x.Value)
                .Select(element => $"{element.Key} - {element.Value}{Environment.NewLine}"))
            {
                File.WriteAllText("../../../expectedResult.txt", text);
            }


        }
    }
}
