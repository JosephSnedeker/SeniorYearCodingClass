using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace writingtoafile
{
    class Program
    {
        static int[,] twoDArray = new int[10, 10];
        static void Main(string[] args)
        {
            string result;
            int x = 0;
            Random rand = new Random();
            string path = AppDomain.CurrentDomain.BaseDirectory + @"Exmple.txt";
            
            for (int i = 0; i < twoDArray.GetLength(0); i++)
            {
                for (int j = 0; j < twoDArray.GetLength(1); j++)
                {
                    twoDArray[i, j] = rand.Next(0, 9);
                }
                
            }
            using (StreamWriter sw = new StreamWriter(path))
            {
                for (int i = 0; i < twoDArray.GetLength(0); i++)
                {
                    for (int j = 0; j < twoDArray.GetLength(1); j++)
                    {
                        sw.Write(twoDArray[i, j]);
                    }
                    sw.WriteLine();

                }
            }

            using (StreamReader sr = new StreamReader(path))
            {
                result = sr.ReadLine();
            }
            Console.Write(result);
            Console.ReadKey();
             

            
        }
    }
}
