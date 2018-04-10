/*
Write a program which represents store.
With the following Functionality:
a. Add client --> Add new client
b. LogIn --> LogIn by exist client
c. Buy --> but some stuff
d. Print All -- > Print all stuff which was bought for exist client
e. Exit --> Exit from store
f. Use: List and Dictionary
g. Client represents by string
h. Stuff represent by string
*/

using System;
using System.Collections.Generic;

namespace Lesson5_1
{
    class BuyingGoods
    {
        public string Customer { get; set; }
        public string Foods { get; set; }
    }

    class Shop
    {
        private List<string> staff;
        private List<string> customer;
        private List<BuyingGoods> purchases;
        private bool resultLogin = false;

        public Shop()
        {
            staff = new List<string>();
            customer = new List<string>();
            purchases = new List<BuyingGoods>();
        }

        public bool CreateGoods(string staff)
        {
            int countStart = this.staff.Count;
            int countEnd;
            this.staff.Add(staff);
            countEnd = this.staff.Count;

            if (countStart != countEnd)
            {
                return true;
            }
            else return false;
        }

        public bool CreateCustomer(string name)
        {
            int countStart = customer.Count;
            int countEnd;
            customer.Add(name);
            countEnd = customer.Count;

            if (countStart != countEnd)
            {
                return true;
            }
            else return false;
        }

        public bool LoginCustomer(string customerName)
        {


            foreach (var name in customer)
            {
                if (name == customerName)
                {
                    resultLogin = true;
                    break;
                }
                else
                {
                    resultLogin = false;
                }
            }

            return resultLogin;
        }

        public void ExitCustomer()
        {
            resultLogin = false;
        }

        public void PrintAll(string customer)
        {
            if (purchases.Count != 0)
            {
                foreach (var item in purchases)
                {
                    if (item.Customer == customer)
                    {
                        Console.WriteLine($"{item.Customer} - {item.Foods}");
                    }
                }

            }
            else
            {
                Console.WriteLine("No active purchases.");
            }

        }

        public void BuyGoods(string customername, string purchase)
        {
            if (staff.Contains(purchase))
            {
                purchases.Add(new BuyingGoods() { Customer = customername, Foods = purchase });
            }
            else
            {
                Console.WriteLine($" Dear, {customername}!  You can't buy this purchase.");
                Console.WriteLine("Food is absent in our shop!");
            }
        }


    }

    class Program
    {

        static void Main()
        {
            bool loginVasilii = false;
            bool loginPetr = false;
            Shop shop = new Shop();

            // Creating goods for our shop.
            shop.CreateGoods("Ice");
            shop.CreateGoods("Banana");
            shop.CreateGoods("Pen");
            shop.CreateGoods("Box");

            // Customer creation.
            shop.CreateCustomer("Vasilii Pupkin");
            shop.CreateCustomer("Petr Vasichkin");

            // Login users.
            loginVasilii = shop.LoginCustomer("Vasilii Pupkin");
            loginPetr = shop.LoginCustomer("Petr Vasichkin");

            // Buy foods.
            if (loginVasilii == true)
            {
                shop.BuyGoods("Vasilii Pupkin", "Banana");
                shop.BuyGoods("Vasilii Pupkin", "Ice");

            }

            if (loginPetr == true)
            {
                shop.BuyGoods("Petr Vasichkin", "ololo");

                // Print all foods.
                shop.PrintAll("Petr Vasichkin");
            }

            // Print all foods.
            shop.PrintAll("Vasilii Pupkin");

            // Exit.
            shop.ExitCustomer();


            Console.ReadKey();

        }
    }
}

