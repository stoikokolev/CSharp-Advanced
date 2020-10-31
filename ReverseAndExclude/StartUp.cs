using System;
using System.Linq;

namespace ReverseAndExclude
{
    class StartUp
    {
        static void Main()
        {
            var list = Console.ReadLine()?.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            var number = int.Parse(Console.ReadLine()!);
            Console.WriteLine(string.Join(' ', list!.Where(x=>x%number!=0).Reverse()));
        }
    }
}
