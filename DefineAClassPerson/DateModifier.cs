using System;
using System.Linq;

namespace DefiningClasses
{
    public class DateModifier
    {
        public int CalculateDifference(string input1, string input2)
        {
            var tokens1 = input1.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var tokens2 = input2.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            var date1 = new DateTime(tokens1[0], tokens1[1], tokens1[2]);
            var date2 = new DateTime(tokens2[0], tokens2[1], tokens2[2]);
            
            return Math.Abs((date2-date1).Days);
        }
    }
}
