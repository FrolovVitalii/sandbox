using System;

namespace Lesson6
{
    class Currency
    {
        private readonly int dollars;
        private readonly int cents;
        private double money;

        public Currency()
        {
            dollars = 0;
            cents = 0;
            money = 0;
        }

        public Currency(int dollars, int cents)
           : this(double.Parse($"{dollars}.{cents}"))
        {

        }

        public Currency(double money)
        {
            this.money = money;
        }


        public double ToDoublel()
        {
            return money;
        }

        public Currency Add(Currency currency)
        {
            return new Currency(money + currency.money);
        }

        public Currency Multiply(int multiplier)
        {
            return new Currency(money * multiplier);
        }

        public override string ToString()
        {
            return String.Format("{0:F2}", money);
        }
    }
}
