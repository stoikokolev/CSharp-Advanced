using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOfPredicates
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var length = int.Parse(Console.ReadLine());
            var dividers = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Distinct()
                .ToList();

            var numbers = new List<int>();
            for (int i = 1; i <= length; i++)
            {
                if (DividersInfo(i, dividers))
                {
                    numbers.Add(i);
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }

        private static bool DividersInfo(int n, IEnumerable<int> dividers)
        {
            bool isTrue = true;
            foreach (int divider in dividers)
            {
                if (n % divider != 0)
                {
                    isTrue = false;
                }
            }
            return isTrue;
        }
    }
}