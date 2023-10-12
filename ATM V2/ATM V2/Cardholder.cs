using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_V2
{
    internal class Cardholder
    {
        public string Name { get; set; }
        public string Lastname { get; set; }
        public int Pin { get; set; }
        public double Balance { get; set; }
        /// <summary>
        /// Get Balance from account
        /// </summary>
        public void getBalance()
        {
            Console.Write("Your Balance is: ");
            Console.WriteLine(Balance);
        }
        /// <summary>
        /// Deposits Money to account
        /// </summary>
        public void doDeposit()
        {
            Console.Clear();
            Console.Write("How much would you like to Deposit: ");
            string input = Console.ReadLine();
            int value = Convert.ToInt32(input);

            Balance = value + Balance;
        }
        /// <summary>
        /// Withdraws money from account
        /// </summary>
        public void doWithdraw()
        {

            Console.Clear();
            getBalance();
            if(Balance > 0)
            {

                
                Console.WriteLine("\n1# 1000Kr");
                Console.WriteLine("2# 500Kr");
                Console.WriteLine("3# 200Kr");
                Console.WriteLine("4# Custom Amount");
                Console.Write("\nInput :");

                int Choice = int.Parse(Console.ReadLine());
                

                if (Choice == 1)
                {
                    int value = 1000;
                    if(value !< Balance)
                    {
                        Console.Clear();
                        Balance = Balance - value;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("You dont have enough balance to Withdraw: " + value);
                    }
                }
                else if (Choice == 2)
                {
                    int value = 500;
                    if (value !< Balance)
                    {
                        Console.Clear();
                        Balance = Balance - value;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("You dont have enough balance to Withdraw: " + value);
                    }
                }
                else if (Choice == 3)
                {
                    int value = 200;
                    if (value !< Balance)
                    {
                        Console.Clear();
                        Balance = Balance - value;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("You dont have enough balance to Withdraw: " + value);
                    }
                }
                else if (Choice == 4)
                {
                    Console.Write("\nHow much would you like to Withdraw: ");
                    string input = Console.ReadLine();
                    int value = Convert.ToInt32(input);
                    if (value! < Balance)
                    {
                        Console.Clear();
                        Balance = Balance - value;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("You dont have enough balance to Withdraw: " + value);
                    }
                }
            }
        }
    }
}
