using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemploop.Models
{
    public class CurrentAccount
    {
        //ctor to iniciate a constructor
        public CurrentAccount(int accountNumb, decimal openingBalance)
        {
            AccountNumb = accountNumb;
            balance = openingBalance;
        }

        public int AccountNumb { get; set; }
        private decimal balance;

        public void Withdraw(decimal value)
        {
            if (value > balance)
            {
                Console.WriteLine("Insufficient funds");
                return;
            }
            else
            {
                Console.WriteLine("Withdrawal successful");
            }
        }

        public void ShowBalance()
        {
            Console.WriteLine($"New Balance: {balance}");
        }
    }
}