using System;
using System.Linq;

namespace KnightsOfHonor
{
    class StartUp
    {
        static void Main()
        {
            Console.WriteLine(string.Join(Environment.NewLine, Console.ReadLine()?.Split().Select(a => $"Sir {a}").ToList()));
        }
    }
}
