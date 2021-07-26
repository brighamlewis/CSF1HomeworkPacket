using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitLoops2
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] fruitArray = { "Apple", "Banana", "Kiwi", "Pomegranate", "Pear", "Orange" };
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(fruitArray[i]);
            }
            for (int i = 0; i < fruitArray.Length; i++)
            {
                Console.Write(".");
            }
            Console.WriteLine("");
        }
    }
}
