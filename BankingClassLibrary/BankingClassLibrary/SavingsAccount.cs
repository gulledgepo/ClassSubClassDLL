//SavingAccounts.cs, Paxston Gulledge
//This class extends upon the BankAccount class
//by including information for savings account customers
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingClassLibrary
{
    public class SavingsAccount : BankAccount
    {
        //Global variables
        //Creating our variables using built in function to auto get and set
        private decimal interestRate { get; set; }
        private decimal minBalance { get; set; }
        public decimal savingsBalance { get; set; }

        public SavingsAccount()
            : base()
        {

        }

        public SavingsAccount(string lname, string fname, string id, decimal intRate, decimal minimumBal, decimal theBalance)
            :base(lname, fname, id)
        {
            interestRate = intRate;
            minBalance = minimumBal;
            savingsBalance = theBalance;
        }

        public override string ToString()
        {
            return base.ToString() + "\nSavings Balance: " + savingsBalance.ToString("C") +
                "\nInterest Rate: " + interestRate.ToString("P2");
        }
    }
}
