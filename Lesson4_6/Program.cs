/*
 You have the natural numbers from 35 to 87. Write a program that will output all the values in order -   stop outputting when it reaches to 71.
*/
using System;
using System.Linq;


namespace Lesson4_6
{
    class Program
    {
        static void Main(string[] args)
        {

            var rangeOfNumbers = Enumerable
                                  .Range(35, 78);

            Console.WriteLine("Output: ");
            Console.WriteLine();
            foreach (var item in rangeOfNumbers)
            {
                if (item <= 71)
                    Console.Write(item + " ");
                else
                    break;
            }
        }
    }
}
