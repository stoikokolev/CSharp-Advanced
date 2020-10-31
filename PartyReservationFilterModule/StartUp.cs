using System;
using System.Collections.Generic;
using System.Linq;

namespace PartyReservationFilterModule
{
    internal static class StartUp
    {
        private static void Main()
        {
            var partyReservation = new PartyReservation(Console.ReadLine());
            string command = Console.ReadLine();

            while (command != null && !command.StartsWith("Print"))
            {
                partyReservation.Command(command);
                command = Console.ReadLine();
            }

            partyReservation.Filter();
            partyReservation.Print();
        }
    }

    internal class PartyReservation
    {
        public PartyReservation(string input)
        {
            this.Guests = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();

            this.Filters = new Dictionary<string, List<string>>();
        }

        private Dictionary<string, List<string>> Filters { get; set; }

        private List<string> Guests { get; set; }

        public void Command(string input)
        {
            var tokens = input.Split(';', StringSplitOptions.RemoveEmptyEntries);
            string key = tokens[1];
            string value = tokens[2];
            switch (tokens[0])
            {
                case "Add filter" when !this.Filters.ContainsKey(key):
                    this.Filters.Add(key, new List<string>() { value });
                    break;
                case "Add filter":
                    this.Filters[key].Add(value);
                    break;
                case "Remove filter" when !this.Filters.ContainsKey(key):
                    break;
                case "Remove filter":
                    {
                        if (this.Filters[key].Contains(value))
                        {
                            this.Filters[key].Remove(value);
                        }

                        break;
                    }
            }

        }

        public void Filter()
        {
            foreach (var (key, list) in this.Filters.Where(x => x.Value.Count > 0))
            {
                switch (key)
                {
                    case "Starts with":
                        {
                            foreach (var value in list)
                            {
                                this.Guests.RemoveAll(x => x.StartsWith(value));
                            }

                            break;
                        }
                    case "Ends with":
                        {
                            foreach (var value in list)
                            {
                                this.Guests.RemoveAll(x => x.EndsWith(value));
                            }

                            break;
                        }
                    case "Contains":
                        {
                            foreach (var value in list)
                            {
                                this.Guests.RemoveAll(x => x.Contains(value));
                            }

                            break;
                        }
                    case "Length":
                        {
                            foreach (var value in list)
                            {
                                this.Guests.RemoveAll(x => x.Length == int.Parse(value));
                            }

                            break;
                        }
                }

            }

        }

        public void Print()
        {
            Console.WriteLine(string.Join(' ', this.Guests));
        }
    }
}
