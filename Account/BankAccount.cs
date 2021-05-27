using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccount.Account
{
    class BankAccount
    {

        static void Main(string[] args)
        {   
            var account = new CustomerAccount();
            account.CustomerDetails("Syam1", 112121212);                       
            Console.WriteLine($"Account {account.AccountNumber} was created for {account.Owner} with {account.Balance} ");
            account.WithDraw(1900);
            Console.WriteLine($"Balance amount after withdraw:  {account.Balance}");
            account.Deposit(1000);
            Console.WriteLine($"Total amount after Deposit:  {account.Balance}");
        }
    }
}