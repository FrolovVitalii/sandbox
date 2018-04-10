/*
 
 + Create Console project.
 + It should ask you to enter an integer value from 0 to 100 inclusive.
 + In case you enter invalid value it should specifically warn you.
 + In case you valid value it should congratulate you and display the value.
 + In case you enter 11, 22, 67 It should send you additional message.
 + In case value is even - It should additionally inform you.
      
 */

using System;

namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter an integer value from 0 to 100 inclusive.");

            if (int.TryParse(Console.ReadLine(), out int enteredValue))
            {

                if (enteredValue < 0 || enteredValue > 100)
                {
                    Console.WriteLine($"You entered: {enteredValue}. It's out of range.");
                }
                else
                {
                    Console.WriteLine($"Good job! You have entered: {enteredValue}.");

                    switch (enteredValue)
                    {
                        case 11:
                        case 22:
                        case 67:
                            Console.WriteLine($"Hey, You entered {enteredValue}");
                            break;
                    }

                    if (enteredValue % 2 == 0)
                        Console.WriteLine("This value is even.");

                }
            }
            else
            {
                Console.WriteLine("You have entered incorrect value. It should be a number.");

            }

            Console.ReadKey();

        }
    }
}
