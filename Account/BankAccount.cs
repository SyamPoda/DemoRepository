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

            int count = 0;
            int accoutnumber = 50009291;

            List<string> list = new List<string>();
            list.Add("AccountHolder1");
            /*list.Add("AccountHolder2");
            list.Add("AccountHolder3"); 
            list.Add("AccountHolder4");
            list.Add("AccountHolder5");*/

            foreach (string item in list)
            {
                account.CustomerDetails(item, accoutnumber);
                Console.WriteLine($"Account {account.AccountNumber} was created for {account.Owner} with {account.Balance} ");
                accoutnumber++;
                count++;
            }
                                    
               account.Deposit(50, DateTime.Now);
               Console.WriteLine($"Total amount after Deposit:  {account.Balance} ");

               account.WithDraw(10, DateTime.Now);
               Console.WriteLine($"Balance amount after withdraw:  {account.Balance}");


        }
    }
}