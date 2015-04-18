using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj górny zakres liczb pierwszych, które chcesz zsumować:");
            int userNumber = int.Parse(Console.ReadLine());

            PrimeNumber primeNumber = new PrimeNumber();

            Console.WriteLine(primeNumber.GetSumOfPrime(userNumber));
            Console.ReadKey();
        }
    }
}
