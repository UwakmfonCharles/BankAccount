using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class Customer

    {

        private string _FirstName;

        private string _LastName;

        public int ID { get; private set; }

        private static int NextID;





        public string FirstName

        {

            get

            {

                return _FirstName;

            }

            private set

            {

                if (value != null && value.Length >= 1)

                { _FirstName = value; }

                else { throw new Exception("Invalid FirstName"); }

            }

        }





        public string LastName

        {

            get

            {

                return _LastName;

            }

            private set

            {

                if (value != null && value.Length >= 1)

                { _LastName = value; }

                else { throw new Exception("Invalid LastName"); }

            }

        }





        public string FullName { get { return FirstName + " " + LastName; } }



        public Customer(string firstName, string lastName)

        {

            FirstName = firstName;

            LastName = lastName;

            ID = NextID;

            NextID++;

        }

    }
}
