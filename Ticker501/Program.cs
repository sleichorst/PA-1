using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticker501
{
    class Program
    {
        static Account acct;
        static void Main(string[] args)
        {
            menu1();
        }

        static void menu1()
        {
            while(true)
            {
                Console.Clear();
                Console.WriteLine("1) Create New Account.");
                Console.WriteLine("2) Open Account.");
                Console.WriteLine("3) Exit.");
                string response = Console.ReadLine();

                if (response.Equals("1"))
                {
                    acct = new Account();
                    menu2();
                }
                else if (response.Equals("2"))
                {
                    //load account
                }
                else if (response.Equals("3"))
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Invalid reponse. Press any key to continue.");
                    Console.ReadKey();
                }
            }

        }

        static void menu2()
        {
            while(true)
            {
                Console.Clear();
                Console.WriteLine("1) Deposit Cash.");
                Console.WriteLine("2) Withdraw Cash.");
                Console.WriteLine("3) See Current Balance.");
                Console.WriteLine("4) Open Portfolio.");
                Console.WriteLine("5) Create New Portfolio.");
                Console.WriteLine("6) Back.");
                string response = Console.ReadLine();

                if (response.Equals("1"))
                {
                    Console.WriteLine("Enter amount to deposit without dollar sign:");
                    response = Console.ReadLine();
                    decimal amount;
                    if (Decimal.TryParse(response, out amount))
                    {
                        acct.Deposit(amount);
                    }
                    else
                    {
                        Console.WriteLine("Amount Invalid. Press any key to continue.");
                        Console.ReadKey();
                    }
                }
                else if(response.Equals("2"))
                {
                    Console.WriteLine("Enter amount to withdraw without dollar sign:");
                    response = Console.ReadLine();
                    decimal amount;
                    if (Decimal.TryParse(response, out amount))
                    {
                        if (acct.Withdraw(amount))
                        {
                            Console.WriteLine("Withdraw Successful. Press any key to continue.");
                        }
                        else
                        {
                            //need to account for positions balance and offer to sell stocks.
                            Console.WriteLine("Insufficient funds. Press any key to continue.");
                            Console.ReadKey();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Amount Invalid. Press any key to continue.");
                        Console.ReadKey();
                    }

                }
                else if (response.Equals("3"))
                {
                    //need to add info about positions balance
                    decimal cashBalance = acct.GetCashBalance();
                    Console.WriteLine("Current balance is: $" + cashBalance.ToString());
                    Console.WriteLine("Press any key to continue.");
                    Console.ReadKey();
                }
                else if (response.Equals("4"))
                {
                    //open protfolio
                }
                else if (response.Equals("5"))
                {
                    //create new portfolio
                }
                else if (response.Equals("6"))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid reponse. Press any key to continue.");
                    Console.ReadKey();
                }

            }

        }
    }
}
