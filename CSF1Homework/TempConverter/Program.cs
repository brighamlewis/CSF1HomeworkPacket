using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempConverter
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Would you like to convert a temperature? y or n");
            string goAgain = Console.ReadLine();

            do
            {
                Console.WriteLine("Would you like to convert from Celsius or Faranheit? ");
                string fOrC = (Console.ReadLine()).ToLower();

                if (fOrC == "faranheit")
                {
                    Console.WriteLine("Please enter a temperature in Farenheit: ");
                    string tempString = Console.ReadLine();
                    decimal tempF = decimal.Parse(tempString);

                    decimal tempC = (tempF - 32m) / (9m / 5m);

                    Console.WriteLine($"The converted temperature in Celsius is {tempC}");

                }
                else if (fOrC == "celsius")
                {
                    Console.WriteLine("Please enter a temperature in Celsius: ");
                    string tempString = Console.ReadLine();
                    decimal tempC = decimal.Parse(tempString);

                    decimal tempF = (((tempC) * (9m / 5m)) + 32m);

                    Console.WriteLine($"The converted temperature in Faranheit is: {tempF}");
                }
                else
                {
                    Console.WriteLine("Invalid Input. Please Try again.");
                    
                }

                Console.WriteLine("Would you like to convert another temperature? y or n");
                goAgain = Console.ReadLine();

            } while (goAgain == "y");
        }
    }
}
