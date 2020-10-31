using System;
using System.Collections.Generic;
using System.Linq;

namespace CustomComparator
{
    class StartUp
    {
        static void Main()
        {
            long[] numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToArray();

            //var evenOddSorter = Comparer<long>.Create((x1, x2) =>
            //{
            //    if (Math.Abs(x1) % 2 == 0 && Math.Abs(x2) % 2 != 0)
            //        return -1;
            //    else if (Math.Abs(x1) % 2 != 0 && Math.Abs(x2) % 2 == 0)
            //        return 1;
            //    else
            //       return x1.CompareTo(x2);
            //});

            
            Console.WriteLine(string.Join(" ", numbers.OrderBy(x => x % 2 != 0).ThenBy(x => x)));
            //Array.Sort(numbers, evenOddSorter);

            //Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
