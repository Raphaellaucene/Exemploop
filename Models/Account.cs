using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemploop.Models
{
    //template to be inherited by child classes
    public abstract class Account
    {
        //protected to allow access by child classes
        protected decimal balance;

        //abstract method to be implemented by child classes
        public abstract void deposit(decimal value);

        public void displayBalance()
        {
            Console.WriteLine($"Current balance: {balance}");
        }
    }
}