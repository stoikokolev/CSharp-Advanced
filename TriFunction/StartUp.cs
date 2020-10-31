using System;
using System.Linq;

namespace TriFunction
{
    class StartUp
    {
        static void Main()
        {
            var length = int.Parse(Console.ReadLine());
            var input = Console.ReadLine().Split().ToList();

            Console.WriteLine(string.Join(' ',input.FirstOrDefault(x => Filter(x,length))));
        }

        private static bool Filter(string word, int length)
        {
            var sum = word.Sum(symbol => (int) symbol);
            return sum >= length;
        }
    }
}
