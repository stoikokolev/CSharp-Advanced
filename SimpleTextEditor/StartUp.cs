using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleTextEditor
{
    class StartUp
    {
        private static void Main()
        {
            var repeats = int.Parse(Console.ReadLine() ?? string.Empty);
            var text = string.Empty;
            var stack = new Stack<string>();
            for (var i = 0; i < repeats; i++)
            {
                var command = Console.ReadLine()?.Split();
                if (command != null)
                    switch (command[0])
                    {
                        case "1":
                            stack.Push(text);
                            text += command[1];
                            break;

                        case "2":
                            stack.Push(text);
                            text = text.Substring(0, text.Length - int.Parse(command[1]));
                            break;

                        case "3":
                            Console.WriteLine(text[int.Parse(command[1]) - 1]);
                            break;

                        case "4":
                            if (stack.Any())
                            {
                                text = stack.Pop();
                            }

                            break;
                    }
            }

        }
    }
}
