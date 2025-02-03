using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk3Ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Inital balance 
            double balance = 1000;

            //loop for the options 
            while (true)
            {
                //display ATM menu
                Console.WriteLine("\nATM Menu:");
                Console.WriteLine("1. Check Balance");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Withdraw");
                Console.WriteLine("4. Exit");

                Console.Write("Choose an Option: ");
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option) 
                {
                    case 1: //check balance
                        Console.WriteLine("Your balance is:" + balance);
                        break;
                        case 2: //Deposit
                        Console.Write("Enter deposit amount: ");
                        double deposit = Convert.ToDouble(Console.ReadLine());
                        if (deposit > 0)
                        {
                            balance += deposit;
                            Console.WriteLine("Deposit successful");
                        }
                        else 
                        {
                            Console.WriteLine("Invalid deposit amount.");
                        }
                        break;
                        case 3: //Withdraw
                        Console.Write("Enter withdrawal amount: ");
                        double withdraw = Convert.ToDouble(Console.ReadLine());
                        if (withdraw > 0 && withdraw <= balance) 
                        {
                            balance -= withdraw;
                            Console.WriteLine("Withdrawal sucessful.");
                        }
                        else if (withdraw > balance)
                        {
                            Console.WriteLine("Insufficient balance.");
                        }
                        else 
                        {
                            Console.WriteLine("Invalid withdraw amount.");
                        }
                        break;
                        case 4: //Exit 
                            Console.WriteLine("Thank you for using the ATM. Goodbye!");
                            return;
                    default: //Invalid option
                        Console.WriteLine("Invalid option. Please choose between 1 and 4.");
                        break;


                }

            }
        }
    }
}
