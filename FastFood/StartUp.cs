using System;
using System.Collections.Generic;
using System.Linq;

namespace FastFood
{
    class StartUp
    {
        static void Main()
        {
            var food = int.Parse(Console.ReadLine() ?? string.Empty);
            var arr = Console.ReadLine()?.Split().Select(int.Parse).ToArray();
            var queue = new Queue<int>(arr ?? Array.Empty<int>());
            Console.WriteLine(queue.Max());
            
            while (true)
            {
                if (queue.Any())
                {
                    if (food - queue.Peek() >= 0)
                    {
                        food -= queue.Peek();
                        queue.Dequeue();
                    }
                    else
                    {
                       Console.WriteLine($"Orders left: {string.Join(' ', queue)}");
                        break;
                    }

                }
                else
                {
                    Console.WriteLine("Orders complete");
                    break;
                }
            }
        }
    }
}
