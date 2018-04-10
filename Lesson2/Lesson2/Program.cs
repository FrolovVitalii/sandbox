using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{

   

    class Program 
    {




        public static int[] GetIntArray(object[] input)
        {
            List<int> listResult = new List<int>();

            var intArray = input
                                .Where(s => s is int)
                                .Cast<int>()
                                .ToArray();

            Array.ForEach(
                intArray, s => listResult
                .Add(intArray
                .Where((v, i) => i != (Array.IndexOf(intArray, s)))
                .Aggregate((i, t) => i * t))
                );


            return listResult.ToArray();
        }

        static void Main(string[] args)
        {

            object[] array = { "e", 3, 2, "tt", 2.4, "1e", 1, 5, "q" };

            Console.WriteLine("Current array:");
            foreach (var item in array)
            {
                Console.Write(item + " :: ");
            }

            

            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine("Result array:");
            foreach (var item in GetIntArray(array))
            {
                Console.Write(item + " :: ");
            }



            Console.ReadKey();
        }
    }
}
