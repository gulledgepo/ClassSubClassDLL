/*BankingApp.cs
Paxston Gulledge, August 11, 2017
Application to present the use of our BankingApp Class Library DLL
Uses classes made in a dll
Program works to be able to store user information
Each new entry is stored in customer ID which increments
Can also look up the information and display it based on
customer ID entered. Additionally, balance values of accounts
can be modified once they are made and then looked up.
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankingClassLibrary;

namespace Week1Assignment1
{
    public partial class BankingApp : Form
    {
        //Global variables
        //Two counters for each of the account types
        int counter = 0;
        //due to the nature of this program having a unique id regardless of
        //where the account is a savings or checkings, a bool will be associated with
        //each counter, true = checkings, false = savings, this is used for lookup later
        bool[] accountType = new bool[100];
        //When we look up a customer ID we want to hold onto it until we clear
        int currentID;
        //Creating a class array for each account type holding up to 100 entries for testing purposes
        CheckingAccount[] checkingAccounts = new CheckingAccount[100];
        SavingsAccount[] savingsAccounts = new SavingsAccount[100];

        public BankingApp()
        {
            InitializeComponent();
        }

        private void ClearForms()
        {
            //Clears all information in our forms
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtServiceOrMin.Text = "";
            txtBalance.Text = "";
            txtInterestRate.Text = "";
            chkFreeChecking.Checked = false;
            chkFreeChecks.Checked = false;
            chkCancelled.Checked = false;            
            txtSearch.Text = "";
            btnDeposit.Visible = false;
            btnWithdraw.Visible = false;
            btnCreate.Visible = true;
            currentID = 99999;
            //Set our main display to show instructions.
            lblDisplay.Text = "Instructions: \n\nSelect which banking account type you would like to create. \nFill out" +
                "all the applicable forms and click create. \n\nOnce an account has been created you can look up the account" +
                "by searching for the Customer ID. \n\nOnce you have looked up an account you can withdraw or deposit to the account.";
        }
        
        private void rdbChecking_CheckedChanged(object sender, EventArgs e)
        {
            //When checkings is checked we update display and clear all existing information
            if (rdbChecking.Checked == true) 
            {
                lblBalance.Text = "Checking Balance:";
                lblServiceOrMin.Text = "Service Charge:";
                lblInterestRate.Visible = false;
                chkFreeChecking.Visible = true;
                chkFreeChecks.Visible = true;
                chkCancelled.Visible = true;
                txtInterestRate.Visible = false;
                ClearForms();

            }
        }

        private void rdbSavings_CheckedChanged(object sender, EventArgs e)
        {
            //When Savings is checked we update the display and clear all existing information
            if (rdbSavings.Checked == true)
            {
                lblBalance.Text = "Savings Balance:";
                lblServiceOrMin.Text = "Minimum Balance:";
                lblInterestRate.Visible = true;
                chkFreeChecking.Visible = false;
                chkFreeChecks.Visible = false;                
                chkCancelled.Visible = false;
                txtInterestRate.Visible = true;
                ClearForms();
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            bool success = true;
            decimal balance;
            decimal serviceCharge;
            //If checking is checked we create a checkings account, otherwise we will create a savings
            if (rdbChecking.Checked == true)
            {
                //Ensuring all numbers are numbers
                try
                {
                    balance = Convert.ToDecimal(txtBalance.Text);
                    serviceCharge = Convert.ToDecimal(txtServiceOrMin.Text);
                }
                catch
                {
                    success = false;
                }
                //Making sure we have numbers and no blank names
                if (success == true && txtFirstName != null && txtLastName != null)
                {
                    checkingAccounts[counter] = new CheckingAccount(txtLastName.Text, txtFirstName.Text, counter.ToString(),
                        chkFreeChecking.Checked, chkFreeChecks.Checked, chkCancelled.Checked, Convert.ToDecimal(txtBalance.Text),
                        Convert.ToDecimal(txtServiceOrMin.Text));
                    ClearForms();
                    accountType[counter] = true;
                    lblDisplay.Text = checkingAccounts[counter].ToString();
                    counter++;
                }
                
            }
            else if (rdbSavings.Checked == true)
            {
                decimal interest;
                //Ensuring all numbers are numbers
                try
                {
                    balance = Convert.ToDecimal(txtBalance.Text);
                    serviceCharge = Convert.ToDecimal(txtServiceOrMin.Text);
                    interest = Convert.ToDecimal(txtInterestRate.Text);
                }
                catch
                {
                    success = false;
                }
                //Making sure we have numbers and no blank names
                if (success == true && txtFirstName != null && txtLastName != null)
                {
                    savingsAccounts[counter] = new SavingsAccount(txtLastName.Text, txtFirstName.Text, counter.ToString(), Convert.ToDecimal(txtInterestRate.Text),
                        Convert.ToDecimal(txtServiceOrMin.Text), Convert.ToDecimal(txtBalance.Text));
                    ClearForms();
                    accountType[counter] = false;
                    lblDisplay.Text = savingsAccounts[counter].ToString();
                    counter++;
                }



            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForms();
        }

        //Looking up the stored classes
        private void btnSearch_Click(object sender, EventArgs e)
        {
            bool success = true;
            int customerID;
            success = (Int32.TryParse(txtSearch.Text, out customerID));
            if (success)
            {
                //Checking from 0 to our counter
                for (int i = 0; i < counter; i++)
                {
                    //If the number entered equals a number in the counter, and the information is not void then we proceed
                    if (i == customerID && (savingsAccounts[i] != null || checkingAccounts[i] != null))
                    {
                        //Hide create button, show withdraw and deposit
                        btnCreate.Visible = false;
                        btnWithdraw.Visible = true;
                        btnDeposit.Visible = true;
                        currentID = i;
                        if (accountType[i] == true)
                        {
                            lblDisplay.Text = checkingAccounts[i].ToString();
                        }
                        else if (accountType[i] == false)
                        {
                            lblDisplay.Text = savingsAccounts[i].ToString();
                        }

                    }
                }
            }
        }
        //Example of modifying the class objects balance values
        private void btnDeposit_Click(object sender, EventArgs e)
        {
            if (accountType[currentID] == true)
            {
                checkingAccounts[currentID].checkingBalance += 500;
                lblDisplay.Text = checkingAccounts[currentID].ToString();
            }
            else if (accountType[currentID] == false)
            {
                savingsAccounts[currentID].savingsBalance += 500;
                lblDisplay.Text = savingsAccounts[currentID].ToString();
            }
            
        }
        //Example of modifying the class objects balance values
        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            if (accountType[currentID] == true)
            {
                checkingAccounts[currentID].checkingBalance -= 500;
                lblDisplay.Text = checkingAccounts[currentID].ToString();
            }
            else if (accountType[currentID] == false)
            {
                savingsAccounts[currentID].savingsBalance -= 500;
                lblDisplay.Text = savingsAccounts[currentID].ToString();
            }
        }

    }
}
