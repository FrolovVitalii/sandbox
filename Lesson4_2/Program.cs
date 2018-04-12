/*
Write a program, which can find a sum of 1 + 2 + 3 + ... + n, where n number entered from the keyboard by the user.
*/
using System;
using System.Linq;


namespace Lesson4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            Console.WriteLine("Please, input value: ");
            if (int.TryParse(Console.ReadLine(), out int inputValue))
            {
                for (int i = 0; i <= inputValue; i++)
                {
                    sum += i;
                }

                Console.WriteLine($"Sum = {sum}");

                Console.WriteLine();
                Console.WriteLine("Another variant using Linq: ");
                Console.WriteLine();

                int sumUsingLinq = Enumerable
                                        .Range(1, inputValue)
                                        .Aggregate((s, next) => s + next);


                Console.WriteLine($"SumUsingLinq = {sumUsingLinq}");
            }

        }
    }
}

