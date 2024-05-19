using System;

namespace ExchangeRate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string codeUsd = "USD";
            decimal rateUsd = 1.7M;

            string codeRub = "RUB";
            decimal rateRub = 0.0187M;

            string codeTry = "TRY";
            decimal rateTry = 0.0527M;


            while (true)
            {
                Console.WriteLine("Enter command: ");
                string command = Console.ReadLine();

                if (command == "/show-recent-currency-rates")
                {
                    Console.WriteLine(codeUsd + ": " + rateUsd);
                    Console.WriteLine(codeRub + ": " + rateRub);
                    Console.WriteLine(codeTry + ": " + rateTry);

                }

                else if (command == "/find-currency-rate-by-code")
                {
                    Console.WriteLine("Enter currency rate: ");
                    string code = Console.ReadLine();


                    if (code == codeUsd)
                    {
                        Console.WriteLine(codeUsd + ": " + rateUsd);
                    }
                    else if (code == codeRub)
                    {
                        Console.WriteLine(codeRub + ": " + rateRub);
                    }
                    else if (code == codeTry)
                    {
                        Console.WriteLine(codeTry + ": " + rateTry);
                    }
                    else
                    {
                        Console.WriteLine("No such currency");
                    }
                }
                else if (command == "/calculate-amount-by-currency")
                {
                    Console.WriteLine("Enter amount: ");
                    decimal amount = decimal.Parse(Console.ReadLine());

                    Console.WriteLine("Enter currency rate: ");
                    string code = Console.ReadLine();

                    if (code == codeUsd)
                    {
                        decimal result = amount * rateUsd;
                        Console.WriteLine(result + "AZN");
                    }
                    else if (code == codeRub)
                    {
                        decimal result = amount * rateRub;
                        Console.WriteLine(result + "AZN");
                    }
                    else if (code == codeTry)
                    {
                        decimal result = amount * rateTry;
                        Console.WriteLine(result + "AZN");
                    }
                    else
                    {
                        Console.WriteLine("No such currency");
                    }
                }
                else if(command == "/exit")
                {
                    break;
                }
            }


        }
    }
}
