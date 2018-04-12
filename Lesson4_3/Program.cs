/*
Write a program to display n terms of natural number and their sum.
*/
using System;
using System.Linq;

namespace Lesson4_3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please, input n value: ");
            Console.WriteLine();

            if (int.TryParse(Console.ReadLine(), out int inputValue))
            {
                Console.WriteLine();

                int sum = Enumerable
                                       .Range(1, inputValue)
                                       .Aggregate((s, next) => s + next);

                Console.WriteLine();
                Console.WriteLine($"Sum = {sum}");
            }

        }
    }
}
