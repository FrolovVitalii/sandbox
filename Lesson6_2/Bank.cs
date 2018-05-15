using System;
using System.Collections.Specialized;
using System.Collections.Generic;


namespace Lesson6_2
{
    class Bank
    {
        private NameValueCollection accountInformation = new NameValueCollection();
        private Dictionary<string, int> accountMoney = new Dictionary<string, int>();
        public void PutMoneyToAccount(IHasId accountHolder, int quantity)
        {
            if (accountMoney.ContainsKey(accountHolder.Id))
            {
                accountInformation.Add(accountHolder.Id, quantity.ToString());
                accountMoney[accountHolder.Id] += quantity;
            }
            else
            {
                accountInformation.Add(accountHolder.Id, quantity.ToString());
                accountMoney.Add(accountHolder.Id, quantity);
            }
        }

        public void GetMoneyFromAccount(IHasId accountHolder, int quantity)
        {
            if (accountMoney.ContainsKey(accountHolder.Id))
            {
                if (GetAccountBalance(accountHolder) >= quantity)
                {
                    accountInformation.Add(accountHolder.Id, (-1 * quantity).ToString());
                    accountMoney[accountHolder.Id] -= quantity;
                }
                else
                {
                    Console.WriteLine("You haven't enough money in your account. ");
                }
            }

        }

        public int GetAccountBalance(IHasId accountHolder)
        {
            int balanse = 0;
            if (accountMoney.ContainsKey(accountHolder.Id))
            {
                balanse = accountMoney[accountHolder.Id];
            }
            return balanse;
        }

        public void GetAllTransactionsByAccount(IHasId accountHolder)
        {
            if (accountMoney.ContainsKey(accountHolder.Id))
            {
                foreach (string s in accountInformation.GetValues($"{accountHolder.Id}"))
                    Console.WriteLine(s);
            }
        }
    }
}
