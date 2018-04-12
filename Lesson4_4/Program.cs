/*
   Write program to prompt the user to choose the correct answer from a list. The user can choose to continue answering the question or stop answering it.
   Input data was changed. You need to write the color of fruit and you will get fruits from API. 
*/
using System;
using System.Net.Http;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Linq;
using System.Data;

namespace Lesson4_4
{
    class Program
    {
        private static string jsonFrutUrl = "http://5accf7c394587a0014eda8c9.mockapi.io/fruits";
        private static string responseString;
        private static DataTable fruits = null;
        private static string inputColor;
        static DataTable GetAndDeserialiseJsonFruits(string urlPath)
        {
            DataTable dataTable = null;

            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(urlPath);
                Task<string> t = client.GetStringAsync(client.BaseAddress);
                responseString = t.Result;
                DataSet dataSet = JsonConvert.DeserializeObject<DataSet>(responseString);
                dataTable = dataSet.Tables["Fruits"];

            }
            catch (Exception ex)
            {
                Console.WriteLine(" ERROR! " + ex.Message);
            }

            return dataTable;
        }


        static void Main(string[] args)
        {
            fruits = GetAndDeserialiseJsonFruits(jsonFrutUrl);

            Console.WriteLine("Please, input fruit color: ");
            Console.WriteLine("For example: Red");
            inputColor = Console.ReadLine();


            foreach (DataRow row in fruits.Rows)
            {
                if (row["Color"].ToString().ToLower() == inputColor.ToLower())
                {
                    Console.WriteLine($"{row["Name"]} - {row["Color"]}");
                }
            }


        }
    }
}
