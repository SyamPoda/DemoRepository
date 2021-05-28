using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccount.Account
{
    public class ArrayExample
    {

        static void Main(string[] args)
        {

            int[] arr1 = new int[5];

            arr1[0] = 15;
            arr1[1] = 17;
            arr1[2] = 19;
            arr1[3] = 25;
            arr1[4] = 27;

            for (int index = 0; index < 5; index++)
            {

                if (arr1[index] > 25)
                {

                    Console.WriteLine("Value is in Array [3]:" + arr1[index]);

                }

            }

            string[] names = new string[5];

            names[0] = "Syam";
            names[1] = "Syam1";
            names[2] = "Syam2";
            names[3] = "Syam3";
            names[4] = "Syam4";

            foreach (string name in names)
            {

                Console.WriteLine($"Name defined in the name are {names}");

            }

            List<string> list = new List<string>();
            list.Add("Syam");
            list.Add("Syam1");
            list.Add("Syam2");

            foreach (string name in list)
            {

                Console.WriteLine($"Name defined in the name are {names}");

            }


            int[] arr = new int[10] { 1, 0, 1, 0, 1, 0, 1, 0, 1, 0 };

            int[] count = new int[10];

            foreach (int item in arr)
            {

                count[item]++;
            }

            Console.WriteLine($"count of {count[0]} and count of {count[1]}");
                 

   

        }

    }
}
