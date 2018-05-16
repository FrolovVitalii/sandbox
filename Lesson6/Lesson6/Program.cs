﻿#region Task1
/*
Create a Currency class that has: -  Constructors with two int parameters - which show dollars and cents With one parameter double no parameters - initialize
with zeros. -  Properties Int dollars  -  total amount of dollars (read-only) Int Cents -  The whole number of cents (read-only) -  Methods double ToDoublel () -  returns 
the double value Currency Add (Currency currency) -  return a new instance of Currency as the sum of the current and the currency parameter. Currency Multiply (int multiplier) 
-  return a   new instance of Currency that has the value of the current multiplied by the number string ToString () -  rotate in the format "D.CC" (for example -  0.20, 20.75, etc.)
(override the ToString()    method from the Object) 
*/
#endregion
using System;


namespace Lesson6
{
    class Program
    {
        static void Main(string[] args)
        {
            Currency currency = new Currency(222, 4566);

            Console.WriteLine($"Currency : {currency.ToDoublel()}");

            Console.WriteLine(new string('-', 20));

            Currency currencyAdd = currency.Add(new Currency(2, 92));

            Console.WriteLine($"ADD : {currencyAdd.ToDoublel()}");

            Console.WriteLine(new string('-', 20));

            Currency currencyMultiply = currency.Multiply(4);

            Console.WriteLine($"Multiply : {currencyMultiply.ToDoublel()}");

            Console.WriteLine(new string('-', 20));

            Console.WriteLine($"ToString : {currency.ToString()}");
#if DEBUG
            Console.ReadKey();
#endif
        }
    }
}