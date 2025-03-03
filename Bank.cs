using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class Bank
    {
        private List<Customer> _customers;
        private List<Account> _accounts;

        public Bank()
        {
            _customers = new List<Customer>();
            _accounts = new List<Account>();
        }

        public void AddCustomer(Customer customer)
        {
            if (_customers.Contains(customer))
            {
                _customers.Add(customer);
            }
        }

        public void AddAccount(Account account)
        {
            if (!_accounts.Contains(account))
            {
                _accounts.Add(account);
            }
        }

        public bool Transfer(int fromID, int toID, int amount)
        {
            Account from = null;
            Account to = null;
            foreach (Account a in _accounts)
            {
                if (a.ID == fromID)
                {
                    from = a;
                }
                if (a.ID == toID)
                {
                    to = a;
                }
            }

            if (from == null || to == null)
            {
                return false;
            }

            if (from.Withdraw(amount))
            {
                return to.Deposit(amount);
            }
            return false;
        }
    
    }
}
