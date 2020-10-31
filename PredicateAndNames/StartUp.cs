using System;
using System.Collections.Generic;
using System.Linq;

namespace PredicateAndNames
{
    class StartUp
    {
        static void Main()
        {
            var nameLength = int.Parse(Console.ReadLine());
            var list = InputToList(Console.ReadLine());
            WriteOutput(list, nameLength);

        }



        static List<string> InputToList(string input) =>
            input.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();

        static void WriteOutput(List<string> list, int nameLength) =>
            Console.WriteLine(string.Join(Environment.NewLine,
                                list.Where(x => x.Length <= nameLength)));
    }
}

