#region Task2
/*
 Person's Class -  has a   name and age. The  Сitizen subsidiary(inherited from Person), that implements the IHasId interface 
- has an identifier code -  the string Id {get;} property. Another class -  LegalPerson (legal entity) - also implements the IHasId interface, 
but is not inherited from Person. Class Bank -  has methods void 
PutMoneyToAccount (IHasId accountHolder, int quantity) - put money on the account
void GetMoneyFromAccount (IHasId accountholder, int quantity)- withdraw money 
from an account int GetAccountBalance (IHasId accountHolder)  -  get an account 
balance Check the bank for both Citizen instances and LegalPerson.
 */
#endregion

using System;


namespace Lesson6_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Person person1 = new Person("Ilya", 20);
            Person person2 = new Person("Vasya", 38);
            Console.WriteLine($"Info about Person 1: {person1.Name}, age: {person1.Age}, ID: {person1.Id}\nInfo about Sitizen 2: {person2.Name}, age: {person2.Age}, ID: {person2.Id}");

            Citizen sitizen1 = new Citizen("Sasha", 32);
            Citizen sitizen2 = new Citizen("Denis", 18);
            Console.WriteLine($"Info about Sitizen 1: {sitizen1.Name}, age: {sitizen1.Age}, ID: {sitizen1.Id}\nInfo about Sitizen 2: {sitizen2.Name}, age: {sitizen2.Age}, ID: {sitizen2.Id}");

            LegalPerson legalPerson1 = new LegalPerson();
            LegalPerson legalPerson2 = new LegalPerson();
            Console.WriteLine($"Legal Person ID = {legalPerson1.Id}");
            Console.WriteLine($"Legal Person ID = {legalPerson2.Id}");

            Bank testBank = new Bank();

            testBank.PutMoneyToAccount(person1, 100);
            testBank.PutMoneyToAccount(person2, 0);
            testBank.PutMoneyToAccount(sitizen1, 30);
            testBank.GetAccountBalance(person1);
            testBank.GetAccountBalance(person2);
            Console.WriteLine($@"Sitizen 1 has: {testBank.GetAccountBalance(sitizen1)}");
            Console.WriteLine($@"Person 1 has: {testBank.GetAccountBalance(person1)}");


            testBank.GetMoneyFromAccount(sitizen1, 20);
            Console.WriteLine($@"Sitizen 1 has: {testBank.GetAccountBalance(sitizen1)}");
            testBank.GetMoneyFromAccount(person1, 8);
            Console.WriteLine($@"Person 1 has: {testBank.GetAccountBalance(person1)}");

            Console.WriteLine(new string('-', 20));
            testBank.GetAllTransactionsByAccount(person1);

#if DEBUG
            Console.ReadKey();
#endif

        }
    }
}
