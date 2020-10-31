using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SantasPresentFactory
{
    class StartUp
    {
        static void Main()
        {

            var dict = new Dictionary<string, int>();
            dict.Add("Doll", 0);
            dict.Add("Teddy bear", 0);
            dict.Add("Bicycle", 0);
            dict.Add("Wooden train", 0);

            var materialStack = new Stack<int>(Console.ReadLine()?.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse) ?? Array.Empty<int>());

            var magicQueue = new Queue<int>(Console.ReadLine()?.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse) ?? Array.Empty<int>());

            while (magicQueue.Count > 0 && materialStack.Count > 0)
            {
                var material = materialStack.Peek();
                var magic = magicQueue.Peek();
                var number = magic * material;
                if (magic == 0 || material == 0)
                {
                    if (magic == 0)
                    {
                        magicQueue.Dequeue();
                    }
                    if (material == 0)
                    {
                        materialStack.Pop();
                    }
                    continue;
                }
                switch (number)
                {
                    case 150:
                        dict["Doll"]++;
                        magicQueue.Dequeue();
                        materialStack.Pop();
                        break;
                    case 250:
                        dict["Wooden train"]++;
                        magicQueue.Dequeue();
                        materialStack.Pop();
                        break;
                    case 300:
                        dict["Teddy bear"]++;
                        magicQueue.Dequeue();
                        materialStack.Pop();
                        break;
                    case 400:
                        dict["Bicycle"]++;
                        magicQueue.Dequeue();
                        materialStack.Pop();
                        break;
                    default:
                        if (number < 0)
                        {
                            number = material + magic;
                            magicQueue.Dequeue();
                            materialStack.Pop();
                            materialStack.Push(number);
                        }
                        else
                        {
                            magicQueue.Dequeue();
                            materialStack.Push(materialStack.Pop() + 15);
                        }
                        continue;
                }
            }

            bool success = (dict["Wooden train"] >= 1 && dict["Doll"] >= 1) || (dict["Teddy bear"] >= 1 && dict["Bicycle"] >= 1);
            var sb = new StringBuilder();
            sb.AppendLine(success ? "The presents are crafted! Merry Christmas!" : "No presents this Christmas!");

            if (materialStack.Any())
            {
                sb.AppendLine($"Materials left: {string.Join(", ", materialStack)}");
            }
            if (magicQueue.Any())
            {
                sb.AppendLine($"Magic left: {string.Join(", ", magicQueue)}");
            }

            foreach (var (key, value) in dict.OrderBy(x => x.Key).Where(x => x.Value > 0))
            {
                sb.AppendLine($"{key}: {value}");
            }

            Console.WriteLine(sb.ToString().Trim());

        }
    }
}
