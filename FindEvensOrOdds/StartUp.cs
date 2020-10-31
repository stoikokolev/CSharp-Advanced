using System;
using System.Collections.Generic;
using System.Linq;

namespace FindEvensOrOdds
{
    class StartUp
    {
        static void Main()
        {
            var list = new List<int>();
            var input = Console.ReadLine()?.Split().Select(int.Parse).ToArray();
            if (input != null)
            {
                var min = input[0];
                var max = input[1];
                for (int i = min; i <= max; i++)
                {
                    list.Add(i);
                }
            }

            var command = Console.ReadLine();
            Console.WriteLine(command == "even"
                ? string.Join(' ', list.Where(x => x % 2 == 0))
                : string.Join(' ', list.Where(x => x % 2 != 0)));
        }
    }
}
