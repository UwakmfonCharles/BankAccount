using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class ChildAccount : Account
    {
        public ChildAccount(Customer customer):base(customer) { }

        
        public override string ToString()
        {
            
            return $"{Customer.ID}. {Customer.LastName},{Customer.FirstName} - Child Account {ID} : Balance {Balance}";  
        }

        public override bool Withdraw(int pAmount)
        {
            if (pAmount > 10)
            {
                
                Console.WriteLine("Cannot withdraw more than 10 from a child account");
                return false;
            }

            return base.Withdraw(pAmount);
        }
       
    }
}
