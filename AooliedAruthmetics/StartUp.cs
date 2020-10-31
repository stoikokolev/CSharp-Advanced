using System;
using System.Linq;

namespace AooliedAruthmetics
{
    class StartUp
    {
        static void Main()
        {
            var array = Console.ReadLine()?.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string command=string.Empty;

            while ((command=Console.ReadLine())!= "end")
            {
                switch (command)
                {
                    case "add":
                        array = array.Select(x => x + 1).ToArray();
                        break;
                    case "multiply":
                        array = array.Select(x => x * 2).ToArray();
                        break;
                    case "subtract":
                        array = array.Select(x => x - 1).ToArray();
                        break;
                    case "print":
                        Console.WriteLine(string.Join(' ',array));
                        break;
                }
            }

        }
    }
}

