using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorpism
{
    public class Account
    {
        public Customer Customer { get; private set; }

        static int nextID;
        public int ID { get; private set; }
        public int Balance { get; private set; }

        public Account(Customer customer, int balance)
        {
            if (balance < 0)
            {
                throw new Exception("Cannot open an account with negative balance");
            }

            Customer = customer;
            Balance = balance;
            ID = nextID;
            nextID++;
        }

        public Account(Customer customer) : this(customer, 0)
        { }

        public bool Deposit(int pAmount)
        {
            if (pAmount < 0)
            {
                return false;
            }
            Balance = Balance + pAmount;
            return true;
        }

        public virtual bool Withdraw(int pAmount)
        {
            if (pAmount < 0)
            {
                return false;
            }

            if (pAmount > Balance)
            {
                return false;
            }

            Balance = Balance - pAmount;
            return true;
        }

        public override string ToString()
        {
            return $"{Customer.ID}. {Customer.LastName},{Customer.FirstName} : Balance {Balance}";
        }
    }
}
