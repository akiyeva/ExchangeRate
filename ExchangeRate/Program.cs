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
            decimal rateRub = 0.022M;

            string codeTry = "TRY";
            decimal rateTry = 0.23M;


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
            }


        }
    }
}
