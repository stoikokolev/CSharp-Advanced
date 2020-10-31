using System;
using System.Collections.Generic;
using System.Linq;

namespace Predicate_Party
{
    class StartUp
    {
        static void Main()
        {
            var partyList = new PartyList(Console.ReadLine());
            while (!partyList.IsParty)
            {
                partyList.Command(Console.ReadLine());
            }

        }

        private class PartyList
        {
            private List<string> _list;

            public PartyList(string input)
            {
                this._list = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
            }

            public bool IsParty { get; private set; }

            public void Command(string input)
            {
                var tokens = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                switch (tokens[0])
                {
                    case "Remove":
                        this.RemoveCommand(tokens[1], tokens[2]);
                        break;
                    case "Double":
                        this.DoubleCommand(tokens[1], tokens[2]);
                        break;
                    case "Party!":
                        this.Party();
                        break;

                }
            }

            private void RemoveCommand(string filter, string criteria)
            {
                switch (filter)
                {
                    case "StartsWith":
                        this._list.RemoveAll(element => element.StartsWith(criteria));
                        break;
                    case "EndsWith":
                        this._list.RemoveAll(element => element.EndsWith(criteria));
                        break;
                    case "Length":
                        this._list.RemoveAll(element => element.Length == int.Parse(criteria));
                        break;
                }
            }

            private void DoubleCommand(string filter, string criteria)
            {
                var newList = new List<string>();
                switch (filter)
                {
                    case "StartsWith":
                        {
                            foreach (var s in this._list)
                            {
                                newList.Add(s);
                                if (s.StartsWith(criteria))
                                {
                                    newList.Add(s);
                                }
                            }

                            break;
                        }
                    case "EndsWith":
                        {
                            foreach (var s in this._list)
                            {
                                newList.Add(s);
                                if (s.EndsWith(criteria))
                                {
                                    newList.Add(s);
                                }
                            }

                            break;
                        }
                    case "Length":
                        {
                            foreach (var s in this._list)
                            {
                                newList.Add(s);
                                if (s.Length == int.Parse(criteria))
                                {
                                    newList.Add(s);
                                }
                            }

                            break;
                        }
                }

                this._list = newList;

            }

            private void Party()
            {
                if (this._list.Count != 0)
                {
                    Console.Write(string.Join(", ", this._list));
                    Console.Write(" are going to the party!");
                }
                else
                {
                    Console.WriteLine("Nobody is going to the party!");
                }
                this.IsParty = true;
            }
        }
    }
}
