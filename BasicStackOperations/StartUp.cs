using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicStackOperations
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
            var stack = new Stack<int>();

            for (var i = 0; i < n; i++)
            {
                if (arr == null) continue;
                var currentNum = arr[i];
                stack.Push(currentNum);
            }

            for (var i = 0; i < s; i++)
            {
                if (stack.Any())
                {
                    stack.Pop();
                }

            }

            if (stack.Contains(x))
            {
                Console.WriteLine("true");
            }
            else
            {
                if (stack.Any())
                {
                    Console.WriteLine(stack.Min());

                }
                else
                {
                    Console.WriteLine("0");
                }
            }
        }
    }
}
