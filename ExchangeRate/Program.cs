using System;

namespace ExchangeRate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] currencyCodes = { "USD", "RUB", "TRY" };
            decimal[] currencyRates = { 1.7M, 0.0187M, 0.0527M };

            while (true)
            {
                Console.WriteLine("Enter command: ");
                string command = Console.ReadLine();

                if (command == "/show-recent-currency-rates")
                {
                    int idx = 0;
                    while (idx < currencyRates.Length)
                    {
                        Console.WriteLine(currencyCodes[idx] + ": " + currencyRates[idx]);
                        idx++;
                    }
                }

                else if (command == "/find-currency-rate-by-code")
                {
                    Console.WriteLine("Enter currency rate: ");
                    string code = Console.ReadLine();


                    if (code == currencyCodes[0])
                    {
                        Console.WriteLine(currencyCodes[0] + ": " + currencyRates[0]);
                    }
                    else if (code == currencyCodes[1])
                    {
                        Console.WriteLine(currencyCodes[1] + ": " + currencyRates[1]);
                    }
                    else if (code == currencyCodes[2])
                    {
                        Console.WriteLine(currencyCodes[2] + ": " + currencyCodes[2]);
                    }
                    else
                    {
                        Console.WriteLine("No such currency");
                    }
                }
                else if (command == "/calculate-amount-by-currency")
                {
                    while (true)
                    {
                        Console.WriteLine("Enter amount: ");
                        if (!decimal.TryParse(Console.ReadLine(), out decimal amount))
                        {
                            Console.WriteLine("Invalid input");
                            continue;
                        }

                        Console.WriteLine("Enter currency rate: ");
                        string code = Console.ReadLine();

                        if (code == currencyCodes[0])
                        {
                            decimal result = amount * currencyRates[0];
                            Console.WriteLine(result + "AZN");
                        }
                        else if (code == currencyCodes[1])
                        {
                            decimal result = amount * currencyRates[1];
                            Console.WriteLine(result + "AZN");
                        }
                        else if (code == currencyCodes[2])
                        {
                            decimal result = amount * currencyRates[2];
                            Console.WriteLine(result + "AZN");
                        }
                        else
                        {
                            Console.WriteLine("No such currency");
                        }
                    }
                }
                else if (command == "/exit")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Unknown command. Available commands:");
                    Console.WriteLine("/show-recent-currency-rates");
                    Console.WriteLine("/find-currency-rate-by-code");
                    Console.WriteLine("/calculate-amount-by-currency");
                    Console.WriteLine("/exit");
                }
            }
        }


    }
}
