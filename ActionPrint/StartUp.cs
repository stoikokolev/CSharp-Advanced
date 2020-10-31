using System;
using System.Linq;

namespace ActionPrint
{
    class StartUp
    {
        static void Main()
        {
            Console.WriteLine(string.Join(Environment.NewLine,
                                        Console.ReadLine()
                                            ?.Split()
                                            .ToArray() ?? Array.Empty<string>()));
        }
    }
}
