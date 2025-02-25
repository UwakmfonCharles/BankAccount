using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class Account

    {

        public Customer Customer { get; private set; }

        public int Balance { get; private set; }

        public int ID { get; private set; }

        private static int NextID;



        public Account(Customer customer) : this(customer, 1)

        { }



        public Account(Customer customer, int startingBalance)

        {

            Customer = customer;

            Balance = startingBalance;

            ID = NextID;

            NextID++;

        }



        public bool Deposit(int pAmount)

        {

            if (pAmount < 0)

            {

                return false;

            }

            Balance = Balance + pAmount;

            return true;

        }



        public bool Withdraw(int pAmount)

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



    }

}
