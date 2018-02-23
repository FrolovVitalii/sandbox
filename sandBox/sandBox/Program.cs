using System;
using System.Collections.Generic;
using System.Linq;
using FirstSprint;

namespace Sendbox
{
    class Program
    {

        static string Reverse(string inputString)
        {
            string result = "";

            for (int i = inputString.Length - 1; i >= 0; i--)
            {
                result += inputString[i];
            }

            return result;
        }

        static int[] GetNumbers(object[] input)
        {

            List<int> result = new List<int>();

            foreach (var item in input)
            {
                if (item is int)
                {
                    result.Add((int)item);
                }
            }
            return result.ToArray();
        }

        static void Main(string[] args)
        {
            TaskLoops LoopTask = new TaskLoops();

            Dictionary<int, string> dictionary;


            #region Revers string Task

            Console.WriteLine("1) Revers string Task");

            string TestString = "Hello World";

            char[] StringOut = TestString.ToCharArray()
                .Reverse()
                .ToArray();

            Console.WriteLine(StringOut);

            Console.WriteLine(new string('*', 20));

            #endregion

            #region Revers string Task anther method

            Console.WriteLine("2) Revers string Task - second method");

            var objects = GetNumbers(new object[] { 1, "2test", new Program(), 4 });

            Console.WriteLine(Reverse("Hello World"));

            Console.WriteLine(new string('*', 20));

            #endregion

            #region Linq Task

            Console.WriteLine("3) Linq Task");

            CollectonOfObjectsTask taskLinq = new CollectonOfObjectsTask();

            List<Object> GetCollectionOfObjects = new List<object>();

            // Add items to collection.
            GetCollectionOfObjects.Add((object)1);
            GetCollectionOfObjects.Add((object)new User { Name = "Ivan", Id = 12, Surname = "Ivanov" });
            GetCollectionOfObjects.Add((object)"Hello world");
            GetCollectionOfObjects.Add((object)new User { Name = "Vitalii", Id = 1, Surname = "Frolov" });
            GetCollectionOfObjects.Add((object)new User { Name = "Vitalii", Id = 2, Surname = "Frolov" });
            GetCollectionOfObjects.Add((object)new User { Name = "Vitalii", Id = 3, Surname = "Frolov" });
            GetCollectionOfObjects.Add((object)new User { Name = "Vitalii", Id = 6, Surname = "Frolov" });
            GetCollectionOfObjects.Add((object)new User { Name = "Volodymyr", Id = 1, Surname = "Kyrychenko" });
            GetCollectionOfObjects.Add((object)new User { Name = "Volodymyr", Id = 2, Surname = "Kyrychenko" });
            GetCollectionOfObjects.Add((object)new User { Name = "Vitalii", Id = 2, Surname = "Frolov" });
            GetCollectionOfObjects.Add((object)new User { Name = "Vasilii", Id = 2, Surname = "Pupkin" });
            GetCollectionOfObjects.Add((object)1);
            GetCollectionOfObjects.Add((object)"Hello world");

            // Get new List with results of task.
            List<User> users = taskLinq.TaskLinqResult(GetCollectionOfObjects);

            // Print results.
            foreach (var user in users)
            {
                Console.WriteLine($"ID: {user.Id}   user: {user.Name} {user.Surname}");
            }

            Console.WriteLine(new string('*', 20));

            #endregion

            #region Compare Versions Task

            Console.WriteLine("4) Compare Versions Task");

            Console.WriteLine(new TaskFunctions().CompareVersions("1.0.0.1", "1.0.0"));

            Console.WriteLine(new string('*', 20));

            #endregion

            #region Task Loops: for - straight

            Console.WriteLine("5) Task Loops: for - straight");

            string[] InputStringArray = new string[] { "test", "test", "test1", "ololo", "test4", "test4", "ololo", "param" };

            dictionary = LoopTask.GetNewDictionary(InputStringArray);

            Console.WriteLine(new string('*', 20));

            #endregion

            #region Task Loops: for - reverse

            Console.WriteLine(" a) Task Loops: for - reverse");

            int[] InputIntArray = { 1, 2, 3, 1, 2, 5, 6, 12, 3 };

            int[] ResultArray = LoopTask.GetArrayWithoutDuplicates(InputIntArray);

            Console.WriteLine("Input Array:");

            foreach (var element in InputIntArray)
            {
                Console.Write(element + " ");
            }

            Console.WriteLine();

            Console.WriteLine("Output Array:");

            foreach (var element in ResultArray)
            {
                Console.Write(element + " ");
            }

            Console.WriteLine();

            Console.WriteLine(new string('*', 20));

            #endregion

            #region Task Loops: foreach

            Console.WriteLine(" b) Task Loops: foreach");

            foreach (var item in dictionary)
            {
                Console.WriteLine($"Item with key : {item.Key} equals: {item.Value}");
            }

            Console.WriteLine(new string('*', 20));

            #endregion

            #region Task Loops: while / do while

            Console.WriteLine(" c) Task Loops: while / do while");

            // Array of our strings.
            string[] ArrayOfString = { "ololo", "ol", "lol", "olololo", "hello", "world" };

            Console.WriteLine("Array of our strings:");

            foreach (var element in ArrayOfString)
            {
                Console.WriteLine($"Element: {element}");
            }

            Console.WriteLine();

            Console.WriteLine("Result of our method GetAndRemoveItemsFromConcurrentBag:");

            LoopTask.GetItemsFromConcurrentBag(ArrayOfString);

            Console.WriteLine(new string('*', 20));

            #endregion

            Console.ReadKey();
        }
    }
}
