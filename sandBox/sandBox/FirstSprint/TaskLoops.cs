using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Linq;


namespace FirstSprint
{
    class TaskLoops
    {
        private Dictionary<int, string> dictionry;

        public TaskLoops()
        {
            dictionry = new Dictionary<int, string>();
        }

        public Dictionary<int, string> GetNewDictionary(string[] InputStringArray)
        {
            dictionry.Add(0, InputStringArray[0]);

            for (int i = 1; i < InputStringArray.Length; i++)
            {
                if (!dictionry.ContainsValue(InputStringArray[i]))
                {
                    dictionry.Add(i, InputStringArray[i]);
                }
            }

            return dictionry;
        }

        public int[] GetArrayWithoutDuplicates(int[] InputArray)
        {
            return InputArray.ToList<int>()
                .Distinct<int>()
                .ToArray<int>();
        }

        public void GetItemsFromConcurrentBag(string[] inputArray)
        {
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
                string element;

                if (instance.TryTake(out element))
                {
                    Console.WriteLine($"Element: {element}");

                }
            }


        }
    }
}
