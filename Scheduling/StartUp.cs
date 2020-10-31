using System;
using System.Collections.Generic;
using System.Linq;

namespace Scheduling
{
    class StartUp
    {
        static void Main()
        {
            var task = new Stack<int>(Console.ReadLine()?.Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse) ?? Array.Empty<int>());

            var thread = new Queue<int>(Console.ReadLine()?.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse) ?? Array.Empty<int>());

            var valueOfTask = int.Parse(Console.ReadLine() ?? string.Empty);

            while (thread.Count > 0 && task.Count > 0)
            {
                var currentTask = task.Peek();
                var currentThread = thread.Peek();
                if (valueOfTask == currentTask)
                {
                    break;
                }
                if (currentThread >= currentTask)
                {
                    task.Pop();
                    thread.Dequeue();
                }
                else
                {
                    thread.Dequeue();
                }
            }

            Console.WriteLine($"Thread with value {thread.Peek()} killed task {task.Peek()}");
            Console.WriteLine(string.Join(' ',thread));

        }
    }
}
