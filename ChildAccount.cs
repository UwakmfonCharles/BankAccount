using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class ChildAccount : Account

    {

        public ChildAccount(Customer customer) : base(customer) { }







        public bool Withdraw(int pAmount)

        {

            if (pAmount > 5)

            {

                Console.WriteLine("You can not withdraw more than  £5");

                return false;

            }

            return Withdraw(pAmount);

        }



    }
}
