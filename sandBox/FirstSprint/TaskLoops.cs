using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;

namespace FirstSprint
{
    class TaskLoops
    {
        private string[] GetRandomStringArray()
        {
            int counter = 0;
            string alphabet = "QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopasdfghjklzxcvbnm";
            List<string> array = new List<string>();
            Random random = new Random();


            while (counter <= random.Next(5,100))
            {
                StringBuilder sb = new StringBuilder(random.Next(2, 30) - 1);
                int position = 0;

                for (int i = 0; i < random.Next(2, 30); i++)
                {
                    position = random.Next(0, alphabet.Length - 1);
                    sb.Append(alphabet[position]);
                }

                array.Add(sb.ToString());
                counter++;
            }

            return array.ToArray<string>();

        }

        public Dictionary<int, string> GetNewDictionary(string[] inputStringArray)
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string>();

            dictionary.Add(0, inputStringArray[0]);

            for (int i = 1; i < inputStringArray.Length; i++)
            {
                if (!dictionary.ContainsValue(inputStringArray[i]))
                {
                    dictionary.Add(i, inputStringArray[i]);
                }
            }

            return dictionary;
        }

        public int[] GetArrayWithoutDuplicates(int[] inputArray)
        {
            return inputArray.ToList<int>()
                .Distinct()
                .ToArray();
        }

        public void GetItemsFromConcurrentBag()
        {
            string[] inputArray = GetRandomStringArray();

            Console.WriteLine("Array of our strings:");

            foreach (var element in inputArray)
            {
                Console.WriteLine($"Element: {element}");
            }

            Console.WriteLine();

            Console.WriteLine("Result of our method GetAndRemoveItemsFromConcurrentBag:");

            ConcurrentBag<string> instance = new ConcurrentBag<string>();

            foreach (string element in inputArray)
            {
                if ((element.Length >= 5) && (element.Length <= 20))
                {
                    instance.Add(element);
                }
            }


            while (instance.Count > 0)
            {                
                if (instance.TryTake(out string element))
                {
                    Console.WriteLine($"Element: {element}");

                }
            }


        }

        public void PrintDictionaryViaForeach(Dictionary<int, string> dictionary)
        {
            foreach (var item in dictionary)
            {
                Console.WriteLine($"Item with key : {item.Key} equals: {item.Value}");
            }
        }
    }
}
