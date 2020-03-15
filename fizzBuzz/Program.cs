using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalFizz = 0;
            int totalBuzz = 0;
            int totalFizzBuzz = 0;

            for (int i = 0; i <= 100; i++)
            {
                if ((i % 3 == 0) && (i % 5 == 0) && (i != 0)){
                    Console.WriteLine("FIZZBuZz!");
                    totalFizzBuzz++;
                }
                else if (i % 3 == 0 && (i != 0))
                    {
                    Console.WriteLine("FIZZ");
                    totalFizz++;
                    }
                else if (i % 5 == 0 && (i != 0))
                {
                    Console.WriteLine("BuZz");
                }
                else
                {
                    Console.WriteLine(i);
                    totalBuzz++;
                }
            }
            Console.WriteLine("Fizz: " + totalFizz + " Buzz: " + totalBuzz + " FizzBuzz: " + totalFizzBuzz);
            Console.WriteLine("Press enter to exit.");
            Console.ReadLine();
            
        }
    }
}
