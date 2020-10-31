using System;
using System.Linq;

namespace CustomMinFunction
{
    class StartUp
    {
        static void Main()
        {
            Console.WriteLine(Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList().Min());
        }
    }
}
