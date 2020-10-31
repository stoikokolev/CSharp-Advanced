using System;
using System.Collections.Generic;
using System.Linq;

namespace BalancedParentheses
{
    class StartUp
    {
        static void Main()
        {
            var arr = Console.ReadLine()?.ToCharArray();
            var stack = new Stack<char>();

            if (arr != null)
                foreach (var symbol in arr)
                {
                    if (!stack.Any())
                    {
                        stack.Push(symbol);
                    }
                    else
                    {
                        switch (stack.Peek())
                        {
                            case '{':
                                if (symbol == '}')
                                {
                                    stack.Pop();
                                }
                                else
                                {
                                    stack.Push(symbol);
                                }

                                break;

                            case '(':
                                if (symbol == ')')
                                {
                                    stack.Pop();
                                }
                                else
                                {
                                    stack.Push(symbol);
                                }

                                break;

                            case '[':
                                if (symbol == ']')
                                {
                                    stack.Pop();
                                }
                                else
                                {
                                    stack.Push(symbol);
                                }

                                break;
                        }
                    }
                }

            Console.WriteLine(stack.Any() ? "NO" : "YES");
        }
    }
}
