using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueClass
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = -1;
            Queue myStack = new Queue();
            while (choice != 0)
            {
                Console.WriteLine("Choose an option");
                Console.WriteLine("1. enQueue");
                Console.WriteLine("2. deQueue");
                Console.WriteLine("3. Peek");
                Console.WriteLine("4. Print");
                Console.WriteLine("5. Search");
                choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    Console.WriteLine("What value to queue");
                    myStack.enQueue(int.Parse(Console.ReadLine()));
                }
                if (choice == 2)
                {
                    if (myStack.deQueue() == -101010)
                    {
                        Console.WriteLine("There is nothing to deQueue");
                    }
                    else
                    {
                        Console.WriteLine(myStack.deQueue() + " has been deQueued");
                    }

                }
                if (choice == 3)
                {
                    if (myStack.Peek() == -101010)
                    {
                        Console.WriteLine("There is nothing to peek");
                    }
                    else
                    {
                        Console.WriteLine(myStack.Peek() + " has been peeked");
                    }

                }
                if (choice == 4)
                {
                    Console.WriteLine();


                    myStack.Print();
                }
                if (choice == 5)
                {
                    List<int> foundValues;
                    Console.WriteLine("What values are you looking for");
                    foundValues = myStack.Search(int.Parse(Console.ReadLine()));
                    Console.WriteLine("The value you searched for is located at ");
                    for (int i = 0; i < foundValues.Count; i++)
                    {
                        Console.WriteLine(foundValues[i]);
                    }


                }
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
