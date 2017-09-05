//CheckingAccount.cs, Paxston Gulledge
//This class extends upon the BankAccount class
//by including information for checking account customers

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingClassLibrary
{
    public class CheckingAccount : BankAccount
    {
        //Global variables
        //Creating our variables using built in function to auto get and set
        private bool freeChecking { get; set; }
        private bool freeChecksProvided { get; set; }
        private bool cancelledChecksReturned { get; set; }
        public decimal checkingBalance { get; set; }
        private decimal serviceCharge { get; set; }

        public CheckingAccount()
            : base()
        {
        }

        public CheckingAccount(string lname, string fname, string id, bool freeCk, bool chkProv,
            bool cancelChk, decimal bal, decimal serviceCh)
            : base(lname, fname, id)
        {
            freeChecking = false;
            freeChecksProvided = false;
            cancelledChecksReturned = false;
            checkingBalance = bal;
            serviceCharge = serviceCh;
        }


        public override string ToString()
        {
            return base.ToString() + "\nChecking Balance: " + checkingBalance.ToString("C") +
                "\nMonthly Service Charge: " + serviceCharge.ToString("C");
        }
    }
}
