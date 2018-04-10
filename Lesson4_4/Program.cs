/*
   Write program to prompt the user to choose the correct answer from a list. The user can choose to continue answering the question or stop answering it.
*/
using System;


namespace Lesson4_4
{
    class Program
    {
        enum Color { Red = 1, Green, Yellow, Blue, Purple };

        static void Main(string[] args)
        {
            Console.WriteLine("What is the color of Banana?");
            Console.WriteLine("Where:");
            Console.WriteLine($"Color {Color.Red}  number {(int)Color.Red}");
            Console.WriteLine($"Color {Color.Green} number {(int)Color.Green}");
            Console.WriteLine($"Color {Color.Yellow} number {(int)Color.Yellow}");
            Console.WriteLine($"Color {Color.Blue} number {(int)Color.Blue}");
            Console.WriteLine($"Color {Color.Purple} number {(int)Color.Purple}");
            Console.WriteLine("Input the number of color:");
            Console.WriteLine("If You want to stop this quiz, please, input 0.");

            while (true)
            {

                Console.WriteLine("Please, input value: ");
                if (int.TryParse(Console.ReadLine(), out int inputValue))
                {
                    Console.WriteLine($" Your choice is {inputValue} ");

                    if ((inputValue == (int)Color.Yellow) || inputValue == 0)
                        break;
                }
            }


        }
    }
}
