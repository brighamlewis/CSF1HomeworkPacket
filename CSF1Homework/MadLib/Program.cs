using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadLib
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("In order to create a story you will need to enter the given prompts: ");

            Console.WriteLine("Please enter a Noun: ");
            string noun1 = Console.ReadLine();

            Console.WriteLine("Please enter a Verb: ");
            string verb1 = Console.ReadLine();

            Console.WriteLine("Please enter a Adjective: ");
            string adj1 = Console.ReadLine();

            Console.WriteLine("Please enter a Noun: ");
            string noun2 = Console.ReadLine();

            Console.WriteLine("Please enter a Verb ending in -ing: ");
            string ingVerb = Console.ReadLine();

            Console.WriteLine("Please enter a Adjective: ");
            string adj2 = Console.ReadLine();

            Console.WriteLine("Please enter a Adverb: ");
            string adverb = Console.ReadLine();

            Console.WriteLine("Please enter an Exclamation: ");
            string exclamation = Console.ReadLine();

            Console.WriteLine("Please enter a City: ");
            string city = Console.ReadLine();

            Console.WriteLine("Please enter a Time: ");
            string time = Console.ReadLine();

            Console.WriteLine($"In a not too far land there was a {noun1} who loved to {verb1}. However, this made him {adj1}. So he decided upon a new hobby, {ingVerb}. While not quite as fulfilling this made him very {adj2}. Therefore he decided to {adverb} exclaim {exclamation}. The news spread throughout {city}. And the rumours lasted until {time}");
        }
    }
}
