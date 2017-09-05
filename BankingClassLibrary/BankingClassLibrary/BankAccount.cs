//BankAccount.cs, Paxston Gulledge
//This is the base account upon which the Checkings
//and savings account will be built from. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingClassLibrary
{
    public abstract class BankAccount
    {
        //Creating our variables using built in function to auto get and set
        private string customerFirstName { get; set; }
        private string customerLastName { get; set; }
        private string customerID { get; set; }

        public BankAccount()
        {

        }

        public BankAccount(string lname, string fname, string id)
        {
            customerLastName = lname;
            customerFirstName = fname;
            customerID = id;
        }

        public BankAccount(string id)
        {
            customerID = id;
        }

        public override string ToString()
        {
            return "Name: " + customerFirstName + " " + customerLastName + "\n" +
                "Customer ID: " + customerID + "\n";
        }
    }
}
