/*
Write a program to display n terms of natural number and their sum.
*/
using System;

namespace Lesson4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            Console.WriteLine("Please, input n value: ");
            Console.WriteLine();

            if (int.TryParse(Console.ReadLine(), out int inputValue))
            {
                Console.WriteLine();

                for (int i = 0; i <= inputValue; i++)
                {
                    sum += i;
                    Console.Write(i + " ");
                }

                Console.WriteLine();
                Console.WriteLine($"Sum = {sum}");
            }

            Console.ReadKey();
        }
    }
}
