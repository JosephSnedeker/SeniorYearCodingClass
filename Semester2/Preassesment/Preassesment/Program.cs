using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preassesment
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            int userInput = 0;
            while (userInput != 9)
            {
                Console.WriteLine("Please enter an integer for the menu option you want to choose: \n1. Print Hello World \n2. Add two integers from user input together\n3. Calulcate the area of a circle given just the radius from user input \n4. Calculate the area of a triangle given the length of all three sides from user input \n5. Given an integer n from user input, draw a square using the ASCII character 'X' that has the width of n \n6. Given an integer n from user input, draw a hollow square using the ASCII character 'X' that has a width of n\n7. Given two integer variables from user input, swap their values\n8. Reverse a string from user input using a for loop\n9. End the program");

                Console.Write("Input:");
                userInput = int.Parse(Console.ReadLine());
                if (userInput == 1)
                {
                    HelloWorld();
                }
                else if (userInput == 2)
                {
                    Add();
                }
                else if(userInput == 3)
                {
                    Circle();
                }
                else if (userInput == 4)
                {
                    Triangle();
                }
                else if (userInput == 5)        
                {
                    Square();
                }
                else if (userInput == 6)
                {
                    HollowSquare();
                }
                else if (userInput == 7)
                {
                    Swap();
                }
                else if (userInput == 8)
                {
                    Reverse();
                }

                
            }
            
        }
        static void HelloWorld()
        {
            Console.WriteLine("Hello World");
        }
        static void Add()
        {
            Console.WriteLine("Please enter the first integer value you want to add: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the second integer value you want to add: ");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine(x + "+" + y + "=" + (x + y));
            Console.WriteLine();
        }
        static void Circle()
        {
            Console.WriteLine("Please enter radius of circle to calculate area: ");
            int radius = int.Parse(Console.ReadLine());
            double area = Math.PI * radius * radius;
            Console.WriteLine("The area of a circle with radius " + radius + " is " + area);
            Console.WriteLine();
        }
        static void Triangle()
        {
            Console.WriteLine("Input length of side A of triangle: ");
            int one = int.Parse(Console.ReadLine());
            Console.WriteLine("Input length of side B of triangle: ");
            int two = int.Parse(Console.ReadLine());
            Console.WriteLine("Input length of side C of triangle: ");
            int three = int.Parse(Console.ReadLine());
            int perimeter = (one + two + three) / 2;
            double area = Math.Sqrt(perimeter * (perimeter - one) * (perimeter - two) * (perimeter - three));
            Console.WriteLine("The area of a triangle with sides " + one + " " + two + " and " + three + " is " + area);
            Console.WriteLine();
        }
        static void Square()
        {
            Console.WriteLine("What size square do you want to draw: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("X");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        static void HollowSquare()
        {
            Console.WriteLine("What size square do you want to draw: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j == 0 || j == n - 1 || i == 0 || i == n - 1)
                    {
                        Console.Write("X");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        static void Swap()
        {
            Console.WriteLine("Please enter the first integer value you want to swap: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the second integer value you want to swap: ");
            int y = int.Parse(Console.ReadLine());
            int holder = x;
            x = y;
            y = holder;
            Console.WriteLine("After swap values are " + x + " and " + y);
            Console.WriteLine();
        }   
        static void Reverse()
        {
            Console.WriteLine("Please enter the string you want to reverse: ");
            string input = Console.ReadLine();
            string reverse = "";
            for (int i = input.Length - 1; i >= 0; i--)
            {
                reverse += input[i];
            }
            Console.WriteLine("Reversed string = " + reverse);
            Console.WriteLine();
        }
    }
}
