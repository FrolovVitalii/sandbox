/*
    You have string array {"apple", "avocado", "banana", "apricot", "jackfruit", "cherimoya", "papaya", "pineapple", "lime", "lemon", "grape", "orange", "grapefruit", "strawberry" }.
Please bring the value which are not contains “ap” to the console.

    Optional: How to get the same result as for string array {"apple", "avocado", "banana", "apricot", "jackfruit", "cherimoya", "papaya", "pineapple", "lime", "lemon", "grape", "orange", "grapefruit", "strawberry" }
for array { "Apple", "Avocado", "Banana", "Apricot", "Jackfruit", "Cherimoya", "Papaya", "Pineapple", "Lime", "Lemon", "Grape", "Orange", "Grapefruit", "Strawberry" } with the same conditions as for previous task?
*/

using System;
using System.Linq;

namespace Lesson4_1

{
    class Program
    {
        static void Main(string[] args)
        {

            string[] array = { "apple", "avocado", "banana", "apricot", "jackfruit", "cherimoya", "papaya", "pineapple", "lime", "lemon", "grape", "orange", "grapefruit", "strawberry" };
            string[] arrayOptionalTask = { "Apple", "Avocado", "Banana", "Apricot", "Jackfruit", "Cherimoya", "Papaya", "Pineapple", "Lime", "Lemon", "Grape", "Orange", "Grapefruit", "Strawberry" };

            Console.WriteLine("Our current array:");
            Console.WriteLine();

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("Our current array for optional task:");
            Console.WriteLine();

            foreach (var item in arrayOptionalTask)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("Value which are not contains ap:");
            Console.WriteLine();

            foreach (var item in array)
            {
                if (!item.Contains("ap"))
                    Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("Value which are not contains ap for optional task:");
            Console.WriteLine();



            foreach (var item in arrayOptionalTask)
            {
                if (!item.ToLower().Contains("ap"))
                    Console.WriteLine(item);
            }


            Console.WriteLine();
            Console.WriteLine("Value which are not contains ap (Using Linq):");
            Console.WriteLine();

            var items = array
                         .Where(s => !s.ToLower().Contains("ap"));

            foreach (var item in items)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
