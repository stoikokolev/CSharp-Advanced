using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main()
        {
            var engines = FillEngineList(int.Parse(Console.ReadLine()));

            var cars = FillCarList(int.Parse(Console.ReadLine()),engines);

            foreach (var car in cars)
            {
                Console.WriteLine(car.ToString());
            }

        }

        public static List<Car> FillCarList(int repeats, Dictionary<string,Engine> engines)
        {
            var cars = new List<Car>();

            for (int i = 0; i < repeats; i++)
            {
                var tokens = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

               
                    var car = new Car(tokens[0],engines[tokens[1]]);
                    
                
                if (tokens.Length == 3)
                {
                    
                    int weight = 0;
                    bool success = int.TryParse(tokens[2], out weight );
                    if (success)
                    {
                        car.Weight = weight;
                    }
                    else
                    {
                        car.Color = tokens[2];
                    }
                    
                }
                else if (tokens.Length == 4)
                {
                    bool success = int.TryParse(tokens[2], out var weight);
                    if (success)
                    {
                        car.Weight = weight;
                        car.Color = tokens[3];
                    }
                    else
                    {
                        car.Color = tokens[2];
                        car.Weight = int.Parse(tokens[3]);
                    }
                    
                }
                
                cars.Add(car);
            }

            return cars;
        }

        public static Dictionary<string,Engine> FillEngineList(int repeats)
        {
            var engines = new Dictionary<string,Engine>();
            for (int i = 0; i < repeats; i++)
            {
                var tokens = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                
                    var engine = new Engine(tokens[0], int.Parse(tokens[1]));
                    
                
                if (tokens.Length == 3)
                {
                    bool success = int.TryParse(tokens[2], out var displacement);
                    if (success)
                    {
                        engine.Displacement = displacement;
                    }
                    else
                    {
                        engine.Efficiency = (tokens[2]);
                    }
                }
                else if (tokens.Length == 4)
                {
                    bool success = int.TryParse(tokens[2], out var displacement);
                    if (success)
                    {
                        engine.Displacement = displacement;
                        engine.Efficiency = (tokens[3]);
                    }
                    else
                    {
                        engine.Efficiency = (tokens[2]);
                        engine.Displacement = int.Parse(tokens[3]);
                    }

                }

                engines.Add(engine.Model, engine);

            }

            return engines;
        }
    }
}
