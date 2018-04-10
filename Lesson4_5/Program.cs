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
                if (enteredPassword == password || enteredPassword == "stop")
                {
                    if (enteredPassword == "stop")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Your password is correct.");
                        Thread.Sleep(1500);
                        break;
                    }

                }
                else
                {
                    Console.WriteLine("Error. Incorrect password!");
                    Console.WriteLine(@"If you need to stop, please, input word:  stop");
                }
            }

        }
    }
}
