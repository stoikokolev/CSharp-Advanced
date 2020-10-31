using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicQueueOperations
{
    class StartUp
    {
        static void Main()
        {
            var input = Console.ReadLine()?.Split().Select(int.Parse).ToArray();
            if (input == null) return;
            var n = input[0];
            var s = input[1];
            var x = input[2];
            var arr = Console.ReadLine()?.Split().Select(int.Parse).ToArray();
            var queue = new Queue<int>();

            for (var i = 0; i < n; i++)
            {
                if (arr == null) continue;
                var currentNum = arr[i];
                queue.Enqueue(currentNum);
            }

            for (var i = 0; i < s; i++)
            {
                if (queue.Any())
                {
                    queue.Dequeue();
                }

            }

            if (queue.Contains(x))
            {
                Console.WriteLine("true");
            }
            else
            {
                if (queue.Any())
                {
                    Console.WriteLine(queue.Min());

                }
                else
                {
                    Console.WriteLine("0");
                }
            }
        }
    }
}
