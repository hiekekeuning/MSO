using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDemo
{
    /* Voorbeeldcode uit de clip over testing */ 
    public class BankAccount
    {
        public string CustomerName { get; }
        public decimal Balance { get; private set; }
        public bool IsFrozen { get; private set; }

        public BankAccount(string name, decimal balance)
        {
            this.CustomerName = name;
            this.Balance = balance;
        }

        public void Debit(decimal amount)
        {
            if (IsFrozen)
            {
                throw new Exception("Account frozen"); // gooi hier liever een eigen exception! (FrozenAccountException o.i.d.)
            }
            if (amount > Balance || amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount"); // kan ook beter
            }
            Balance -= amount;
        }
        public void Credit(decimal amount)
        {
            if (IsFrozen)
            {
                throw new Exception("Account frozen");
            }
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount");
            }
            Balance += amount;
        }

        public void Freeze()
        {
            IsFrozen = true;

        }
        public void Unfreeze() 
        {
            IsFrozen = false;
        }

    }
}
