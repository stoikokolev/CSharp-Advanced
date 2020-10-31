using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FashionBoutique
{
    class StartUp
    {
        static void Main()
        {
            var arr = Console.ReadLine()?.Split().Select(int.Parse).ToArray();
            var stack = new Stack<int>((arr ?? Array.Empty<int>()).Reverse());
            var capacity = int.Parse(Console.ReadLine() ?? string.Empty);
            var left = capacity;
            var count = 1;

            while (stack.Any())
            {
                if (left - stack.Peek() >= 0)
                {
                    left -= stack.Pop();

                }
                else
                {
                    count++;
                    left = capacity;

                }
            }

            Console.WriteLine(count);
        }
    }
}
