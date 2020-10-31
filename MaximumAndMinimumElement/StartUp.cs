using System;
using System.Collections.Generic;
using System.Linq;

namespace MaximumAndMinimumElement
{
    class StartUp
    {
        static void Main()
        {
            var repeats = int.Parse(Console.ReadLine() ?? string.Empty);
            var stack = new Stack<int>();
            for (var i = 0; i < repeats; i++)
            {
                var input = Console.ReadLine();
                if (input != null)
                {
                    var arr = input.Split().Select(int.Parse).ToArray();
                    switch (arr[0])
                    {
                        case 1:
                            stack.Push(arr[1]);
                            break;

                        case 2:
                            stack.Pop();
                            break;

                        case 3:
                            if (stack.Any())
                            {
                                Console.WriteLine(stack.Max());
                            }

                            break;

                        case 4:
                            if (stack.Any())
                            {
                                Console.WriteLine(stack.Min());
                            }

                            break;

                    }
                }
            }

            Console.WriteLine(string.Join(", ",stack));
        }
    }
}
