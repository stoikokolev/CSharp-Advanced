using System;
using System.Collections.Generic;
using System.Linq;

namespace SongsQueue
{
    class StartUp
    {
        static void Main()
        {
            var que = new Queue<string>(Console.ReadLine()?.Split(", ").ToArray() ?? Array.Empty<string>());
            while (que.Any())
            {
                var command = Console.ReadLine();
                if (command == "Play")
                {
                    que.Dequeue();
                }
                else if (command != null && command.Contains("Add"))
                {
                    var song = command.Substring(4);
                    if (que.Contains(song))
                    {
                        Console.WriteLine($"{song} is already contained!");
                    }
                    else
                    {
                        que.Enqueue(song);
                    }

                }
                else if (command == "Show")
                {
                    Console.WriteLine(string.Join(", ", que));
                }

            }
            Console.WriteLine("No more songs!");
        }
    }
}
