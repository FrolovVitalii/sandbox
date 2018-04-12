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

    static class Program
    {

        static void ConsoleWriteArray(this string[] array)
        {
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }


        static void CosoleWriteArrayWithoutTemlate(this string[] array, string template)
        {
            foreach (var item in array)
            {
                if (!item.ToLower().Contains(template))
                {
                    Console.WriteLine(item);
                }
            }
        }



        static void Main(string[] args)
        {

            string[] array = { "apple", "avocado", "banana", "apricot", "jackfruit", "cherimoya", "papaya", "pineapple", "lime", "lemon", "grape", "orange", "grapefruit", "strawberry" };
            string[] arrayOptionalTask = { "Apple", "Avocado", "Banana", "Apricot", "Jackfruit", "Cherimoya", "Papaya", "Pineapple", "Lime", "Lemon", "Grape", "Orange", "Grapefruit", "Strawberry" };

            Console.WriteLine("Our current array:");
            Console.WriteLine();

            ConsoleWriteArray(array);

            Console.WriteLine();
            Console.WriteLine("Our current array for optional task:");
            Console.WriteLine();

            ConsoleWriteArray(arrayOptionalTask);

            Console.WriteLine();
            Console.WriteLine("Value which are not contains ap:");
            Console.WriteLine();

            CosoleWriteArrayWithoutTemlate(array, "ap");

            Console.WriteLine();
            Console.WriteLine("Value which are not contains ap for optional task:");
            Console.WriteLine();

            arrayOptionalTask.CosoleWriteArrayWithoutTemlate("ap");

            Console.WriteLine();
            Console.WriteLine("Value which are not contains ap (Using Linq):");
            Console.WriteLine();

            var items = array
                         .Where(s => !s.ToLower().Contains("ap"))
                         .ToArray();

            ConsoleWriteArray(items);

#if DEBUG
            Console.ReadKey();
#endif
        }
    }
}
