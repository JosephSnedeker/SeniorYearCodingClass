using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayManipulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            int seed = 1234;
            Random rand = new Random(seed);

            //Apply random values of 0-9 to the array. Note: This does not prevent duplicates
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(0, 10);
            }




            //The following can be used to test your implementations. Uncomment each line as you go to test.
            //NOTE: You don't have to do each line sequentially. For example, implementing the FindMin and FindMax methods
            //will be very useful for your FindRange method. Hint... Hint...

            Console.WriteLine("UNSORTED: ");
            PrintArray(array);
            Console.WriteLine("BUBBLE SORTED: ");
            PrintArray(BubbleSort(array));
            Console.WriteLine("SELECTION SORTED: ");
            PrintArray(SelectionSort(array));
            Console.WriteLine("MEAN: " + FindMean(array));
            Console.WriteLine("MEDIAN: " + FindMedian(SelectionSort(array)));
            Console.WriteLine("RANGE: " + FindRange(array));
            Console.WriteLine("MODE: " + FindMode(array));
            Console.WriteLine("MAX: " + FindMax(array));
            Console.WriteLine("MIN: " + FindMin(array));
        }

        /// <summary>
        /// Prints the array in | x | y | z | a | b | c | format
        /// </summary>
        /// <param name="array">The array to be printed</param>
        public static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("| " + array[i] + " ");
            }
            Console.WriteLine("|");
        }

        /// <summary>
        /// Implements a bubble sort algorithm to sort the array
        /// </summary>
        /// <param name="array">The array to sort</param>
        /// <returns>The sorted array</returns>
        public static int[] BubbleSort(int[] array)
        {
            bool swapped;
            int[] mutatedArray = new int[array.Length];
            array.CopyTo(mutatedArray, 0);


            do
            {
                swapped = false;
                for (int i = 0; i < mutatedArray.Length - 1; i++)
                {
                    if (mutatedArray[i] > mutatedArray[i + 1])
                    {
                        int placeholder = mutatedArray[i];
                        mutatedArray[i] = mutatedArray[i + 1];
                        mutatedArray[i + 1] = placeholder;
                        swapped = true;
                    }
                   
                }

            } while (swapped);
            return mutatedArray;
        }

        /// <summary>
        /// Implements a selection sort algorithm to sort the array
        /// </summary>
        /// <param name="array">The array to sort</param>
        /// <returns>The sorted array</returns>
        public static int[] SelectionSort(int[] array)
        {
            int[] mutatedArray = new int[array.Length];
            array.CopyTo(mutatedArray, 0);
            for (int i = 0; i < mutatedArray.Length - 1; i++)
            {
                for (int j = i + 1; j < mutatedArray.Length; j++)
                {
                    if (mutatedArray[i] > mutatedArray[j])
                    {
                        int placeholder = mutatedArray[i];
                        mutatedArray[i] = mutatedArray[j];
                        mutatedArray[j] = placeholder;
                    }

                }
            }
            return mutatedArray;
            

        }

        /// <summary>
        /// Finds the mean (average) of the array
        /// </summary>
        /// <param name="array">The array</param>
        /// <returns>The mean</returns>
        public static decimal
            FindMean(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                sum += array[i];
            }
            decimal mean = decimal.Divide(sum, array.Length);
            return mean;
        }

        /// <summary>
        /// Finds the median (middle element of sorted array) of the array
        /// In the case that the array is an even length, average the two middle elements
        /// </summary>
        /// <param name="array">The array</param>
        /// <returns>The median</returns>
        public static float FindMedian(int[] array)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Finds the range (highest value - lowest value) of the array
        /// </summary>
        /// <param name="array">The array</param>
        /// <returns>The range</returns>
        public static int FindRange(int[] array)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Finds the mode (most common occuring element) of the array
        /// </summary>
        /// <param name="array">The array</param>
        /// <returns>The mode</returns>
        public static int FindMode(int[] array)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Finds the maximum value inside the array
        /// </summary>
        /// <param name="array">The array</param>
        /// <returns>The maximum value</returns>
        public static int FindMax(int[] array)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Finds the minimum value inside the array
        /// </summary>
        /// <param name="array">The array</param>
        /// <returns>The minimum value</returns>
        public static int FindMin(int[] array)
        {
            throw new NotImplementedException();
        }
    }
}
