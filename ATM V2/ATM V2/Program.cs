using System.Net.NetworkInformation;
using System.Xml.Serialization;

namespace ATM_V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region CardHolder

            Cardholder cardholder1 = new Cardholder();
            cardholder1.Name = "Einars";
            cardholder1.Lastname = "Lapins";
            cardholder1.Pin = 1234;
            cardholder1.Balance = 100;

            #endregion

            #region Variables
            int tries = 1;
            int maxattempts = 3;
            int Choice = 0;
            #endregion

            #region ATM
            bool ATM = true ;
            do
            {
                Mainmenu();
                
                int pin = ReadInt("Input:");

                Console.Clear();
                
                if (cardholder1.Pin == pin)            
                {
                    cardholder1.getBalance();
                    do
                    {
                        secondmenu();

                        Choice = ReadInt("Input:");

                        if (Choice == 1)
                        {
                            cardholder1.doDeposit();
                            Console.Clear();
                            cardholder1.getBalance();
                        }
                        else if (Choice == 2)
                        {
                            cardholder1.doWithdraw();
                            cardholder1.getBalance();
                        }

                    } while (Choice != 3);
                    Console.Clear();
                }
                else if (cardholder1.Pin != pin)
                {
                    if (tries == maxattempts)
                    {
                        ATM = false;
                    }
                    Console.Clear();
                    Console.WriteLine($"Wrong PIN, You have: {maxattempts - tries} Tries Left");
                    tries++;
                }

            } while (ATM);
            #endregion
        }
        static void Mainmenu()
        {
            Console.WriteLine("---Insert Your Card---");

            for (int i = 0; i < 25; i++) 
            {
                Console.Write("-"); Task.Delay(1).Wait();  //speed 45
            }
            Console.WriteLine("\nEnter Your 4 Digit PIN Number");
        }
        static void secondmenu()
        {
            Console.WriteLine("\n1# Deposit");
            Console.WriteLine("\n2# Withdraw");
            Console.WriteLine("\n3# Exit to Main Menu");
            Console.WriteLine("-------------------");
        }
        static int ReadInt(string promt)
        {
            Console.Write(promt);
            string input = Console.ReadLine();
            int value = Convert.ToInt32(input);
            return value;
        }
    }
}