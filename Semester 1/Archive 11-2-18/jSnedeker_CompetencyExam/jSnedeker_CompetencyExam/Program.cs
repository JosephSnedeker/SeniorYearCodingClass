using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jSnedeker_CompetencyExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 1;
            while (k != 0)
            {
                Console.WriteLine("******************************");
                Console.WriteLine("** 1. Conditionals");
                Console.WriteLine("** 2. For Loops");
                Console.WriteLine("** 3. While Loops");
                Console.WriteLine("** 4. Arrays");
                Console.WriteLine("** 5. Lists");
                Console.WriteLine("** 0. Quit");
                Console.WriteLine("******************************");
                int x = int.Parse(Console.ReadLine());
                // condtionals
                if (x == 1)
                {
                    Console.WriteLine("What grade are you in?");
                    int grade = int.Parse(Console.ReadLine());
                    Console.WriteLine("What is your reading level");
                    int readLevel = int.Parse(Console.ReadLine());
                    if (grade > 8 && readLevel >= grade)
                    {
                        Console.WriteLine("You are in high school & read proficiently ");
                    }
                    if (grade > 8 && readLevel < grade)
                    {
                        Console.WriteLine("You are in high school & don't read proficiently ");
                    }
                    else if (grade > 5 && readLevel >= grade)
                    {
                        Console.WriteLine("You are in middle school & read proficiently");
                    }
                    else if (grade > 5 && readLevel < grade)
                    {
                        Console.WriteLine("You are in middle school & don't read proficiently");
                    }
                    else if (grade > 0 && readLevel >= grade)
                    {
                        Console.WriteLine("You are in elementary school & read proficiently");
                    }
                    else if (grade > 0 && readLevel < grade)
                    {
                        Console.WriteLine("You are in elementary school & don't read proficiently");
                    }


                    Console.ReadKey();
                    Console.Clear();
                }
                // for loops
                if (x == 2)
                {
                    Console.WriteLine("What value do you want to iterate by?");
                    int iterate = int.Parse(Console.ReadLine());
                    Console.WriteLine("What number do you want to count to?");
                    int countTo = int.Parse(Console.ReadLine());
                    for (int i = 0; i < countTo + iterate; i += iterate)
                        Console.WriteLine(i);
                    Console.ReadKey();
                    Console.Clear();
                }
                //While Loops
                if (x == 3)
                {
                    int value = 0;
                    int userAdd = 1;
                    Console.WriteLine("Enter numbers to add togehter. Enter zero to end the while loop");
                    while (userAdd != 0)
                    {
                        Console.Write("Enter a value to add: ");
                        userAdd = int.Parse(Console.ReadLine());
                        value = value + userAdd;
                        Console.WriteLine("New sum = " + value);
                        
                            

                    }
                    Console.ReadKey();
                    Console.Clear();

                }
                //Arrays
                if (x == 4)
                {
                    Console.WriteLine("You have an array of size ten, please enter numbers to populate the array");
                    int[] myIntArray = new int[10];
                    for (int i = 0; i < 10; i++)
                    {
                        Console.WriteLine("Please enter a number to add");
                        myIntArray[i] = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("You're array is: ");
                    for (int i = 0; i < 10; i++)
                    {
                        Console.WriteLine("Array at " + i + ": " + myIntArray[i]);
                    }
                    Console.ReadKey();
                    Console.Clear();
                }
                // lists
                if (x == 5)
                {
                    List<string> userList = new List<string>();
                    Console.WriteLine("enter words to add to a string list, type end to see your list");
                    while (!userList.Contains("end"))
                        userList.Add(Console.ReadLine());
                    userList.RemoveAt(userList.Count - 1);
                    for (int i = 0; i < userList.Count; i++)
                        Console.WriteLine("String " + i + ": " + userList[i]);
                    Console.ReadKey();
                    Console.Clear();
                }
                if (x == 0)
                    k = 0;

            }





        }
    }
}
