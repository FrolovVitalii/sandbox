using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6
{
    class Currency
    {
        private readonly int Dollars;
        private readonly int Cents;
        private double money;

        public Currency(int dollars, int cents)
        {
            this.Dollars = dollars;
            this.Cents = cents;
            this.money = double.Parse($"{dollars}.{cents}");
        }

        public double ToDoublel()
        {
            return this.money;
        }

        public Currency Add(Currency currency)
        {
            return new Currency(this.Dollars + currency.Dollars, this.Cents + currency.Cents);
        }

        public Currency Multiply(int multiplier)
        {
            return new Currency(this.Dollars * multiplier, this.Cents * multiplier);
        }

        public override string ToString()
        {
            return String.Format("{0:F2}", money);
        }
    }
}
