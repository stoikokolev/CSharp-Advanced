using System;
using System.Collections.Generic;
using System.Linq;

namespace TruckTour
{
    class StartUp
    {
        static void Main()
        {
            var repeats = int.Parse(Console.ReadLine() ?? string.Empty);
            var start = -1;
            var finished = false;
            var qu = new Queue<Pump>();

            for (var i = 0; i < repeats; i++)
            {
                var arr = Console.ReadLine()?.Split().Select(int.Parse).ToArray();
                if (arr == null) continue;
                var pump = new Pump { Fuel = arr[0] - arr[1] };
                qu.Enqueue(pump);
            }

            while (!finished)
            {
                start++;
                var tank = 0;

                foreach (var pump in qu)
                {
                    tank += pump.Fuel;

                    if (tank < 0)
                    {

                        break;
                    }

                }

                if (tank >= 0)
                {
                    finished = true;
                    continue;
                }

                qu.Enqueue(qu.Dequeue());

            }

            Console.WriteLine(start);
        }

        private class Pump
        {
            public int Fuel { get; set; }

        }
    }
}
