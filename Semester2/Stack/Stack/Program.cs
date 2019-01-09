using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int choice = -1;
            Stack myStack = new Stack();
            while (choice != 0)
            {
                Console.WriteLine("Choose an option");
                Console.WriteLine("1. Push");
                Console.WriteLine("2. Pop");
                Console.WriteLine("3. Peek");
                Console.WriteLine("4. Print");
                Console.WriteLine("5. Search");
                choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    Console.WriteLine("What value to push");
                    myStack.Push(int.Parse(Console.ReadLine()));
                }
                if (choice == 2)
                {
                    Console.WriteLine(myStack.Pop() + " has been popped");
                }
                if (choice == 3)
                {
                    Console.WriteLine(myStack.Peek() + " has been peeked");
                }
                if (choice == 4)
                {
                    Console.WriteLine();


                    myStack.Print();
                }
                if(choice == 5)
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
