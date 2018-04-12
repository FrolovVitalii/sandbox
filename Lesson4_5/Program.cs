/*
   Write a program that will "ask" the correct password, as long as it is entered. The correct password will be the «root». 
*/

using System;
using System.Threading;


namespace Lesson4_5
{
    class Program
    {
        private static string password = "root";
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter password: ");
                var enteredPassword = Console.ReadLine();
                if (enteredPassword == password)
                {
                    Console.WriteLine("Your password is correct.");
                    break;
                }
                else
                {
                    Console.WriteLine("Error. Incorrect password!");
                }
            }

        }
    }
}
