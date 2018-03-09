using System;


namespace Lesson1
{
    class Program
    {
        static string name = null;
        static void Main()
        {
            Console.WriteLine("Please, enter your name.");

            name = Console.ReadLine();

            if (!string.IsNullOrEmpty(name))
            {
                Console.WriteLine($"Hello, {name} !");
            }
            else
            {
                Console.WriteLine("You didn't write your name!");
            }

            Console.ReadKey();
        }
    }
}
