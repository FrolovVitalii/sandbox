/*
 
 1) Write a program to read n number of values in an array and display it. 
 2) Write a program to read last n number of values in an array and display it.  
  
 */

using System;

namespace Lesson5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 1, 2, 3, 4, 5 };
            // string[] array = { "qqqq", "dddqq", "qqqdd", "111", "qq5", "uuu6", "uuu7", "www1", "hhhh2", "ff3", "aa4", "ff5" };
            int counter = 0;


            Console.WriteLine("Current array: ");
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
            Console.WriteLine(new String('*', 20));
            Console.WriteLine("Enter n value: ");

            if (int.TryParse(Console.ReadLine(), out int enteredValue))
            {
                Console.WriteLine();
                if (enteredValue < array.Length - 1)
                {
                    Console.WriteLine("From the beggin of array:");

                    for (var i = 0; i <= enteredValue - 1; i++)
                    {
                        Console.Write(array[i] + " ");
                    }

                    Console.WriteLine();
                    Console.WriteLine("From the end of array:");
                    Console.WriteLine();

                    for (var i = array.Length - 1; i >= 0; i--)
                    {
                        if (counter < enteredValue)
                        {
                            Console.Write(array[i] + " ");
                            counter++;
                        }
                        else
                        {
                            break;
                        }

                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Error. Out of range!");
                }
            }

            Console.ReadKey();
        }
    }
}
