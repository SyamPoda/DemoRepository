using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccount.Account
{
    public class CustomerAccount
    {
        private int accountNumber;
        private string owner;
        private decimal balance = 100;
        public void CustomerDetails(string name,int accountNumber)
        {
            this.owner = name;            
            this.accountNumber = accountNumber;
            //accountNumber++;
        }
        private List<Transactions> allTransactions = new List<Transactions>();
        public int AccountNumber
        {
            get
            {
                return accountNumber;
            }

            set
            {

                if (value > 0)
                {
                    this.accountNumber = value;
                }

                else
                {

                    throw new ArgumentOutOfRangeException("Invalid account number");

                }
            }
        }

        public string Owner
        {
            get
            {
                return owner;
            }

            set
            {                               
                    this.owner = value;
                }

               
            }

        public decimal Balance
        {
            get
            {
                foreach (var item in allTransactions)
                {
                    balance += item.Amount;
                }

                return balance;
            }

            set
            {

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

        public void Deposit(decimal amount, DateTime date)
        {

            if (amount > 0)
            {

                var deposit = new Transactions(amount, date);
                allTransactions.Add(deposit);
            }
            else
            {
                throw new ArgumentOutOfRangeException("Amount of deposit must be positive");
            }
        }


        public void WithDraw(decimal amount, DateTime date)
        {
            if (amount < balance)
            {
                var withdrawal = new Transactions(balance-amount, date);
                allTransactions.Add(withdrawal);
            }
            else
            {
                throw new ArgumentOutOfRangeException("Insufficent funds available in your account to withdraw");
            }
        }

        



    }      
       

    }

