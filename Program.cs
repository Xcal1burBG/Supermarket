using System;
using System.Collections.Generic;

namespace Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<String> shopQueue = new Queue<String>();

            string input = Console.ReadLine();

            while (input != "End")
            {
                if (input != "Paid") //input = next person in the queue
                {
                    shopQueue.Enqueue(input);
                }

                else //input = "Paid"

                    for (int i = 0; i < shopQueue.Count; i++)
                    {
                        Console.WriteLine(shopQueue.Peek());
                        shopQueue.Dequeue();
                        i--;
                    }

                input = Console.ReadLine();

            }
            Console.WriteLine($"{shopQueue.Count} people remaining.");

        }

    }
}

