using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccount.Account
{
    public class CustomerAccount
    {
        public int AccountNumber { get; set; }
        public string Owner { get; set; }      
                
        public void CustomerDetails(string name,int accountNumber)
        {
            this.Owner = name;            
            this.AccountNumber = accountNumber;
            accountNumber++;
        }

        private decimal balance = 1000;
        public decimal Balance
        {
            get
            {
                return balance;
            }

            set { 

                if (value > 0)
                {
                    this.balance = value;
                }

                else
                {

                    throw new ArgumentOutOfRangeException("Account balance is 0");
                
                }
            }
        }
        public void WithDraw(decimal amount)
        {
            if (amount < balance)
            {
                balance = balance - amount;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Insufficent funds available in your account to withdraw");
            }
        }

        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                balance = balance + amount;
            }
            else 
            {
                throw new ArgumentOutOfRangeException("Negative value is not allowed");
            }
        }


    }
}
