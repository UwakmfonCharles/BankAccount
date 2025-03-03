using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorpism
{
    public class Customer
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int ID { get; private set; }
        static int nextID = 1;

        public Customer(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            ID = nextID;
            nextID++;
            
        }

        
    }
}
