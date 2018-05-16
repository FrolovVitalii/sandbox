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
                Operations(quantity, accountHolder, "PutMoney");
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
                    Operations(quantity, accountHolder, "GetMoney");
                }
                else
                {
                    throw new Exception("Error! You haven't enough money in your account. "); 
                }
            }

        }

        public int GetAccountBalance(IHasId accountHolder)
        {

            if (!accountMoney.ContainsKey(accountHolder.Id))
            {
                throw new Exception($"Error! Account with id: {accountHolder.Id} does not exist.");
            }
            return accountMoney[accountHolder.Id];
        }

        public void GetAllTransactionsByAccount(IHasId accountHolder)
        {
            if (accountMoney.ContainsKey(accountHolder.Id))
            {
                foreach (string s in accountInformation.GetValues($"{accountHolder.Id}"))
                    Console.WriteLine(s);
            }
        }

        private void Operations(int quantity, IHasId accountHolder, string operation)
        {
            if (quantity > 0)
            {
                if (operation == "PutMoney")
                {
                    accountInformation.Add(accountHolder.Id, quantity.ToString());
                    accountMoney[accountHolder.Id] += quantity;
                }
                else if (operation == "GetMoney")
                {
                    accountInformation.Add(accountHolder.Id, (-1 * quantity).ToString());
                    accountMoney[accountHolder.Id] -= quantity;
                }
                else throw new Exception("Error! Operation impossible.");

            }
        }

    }
}
