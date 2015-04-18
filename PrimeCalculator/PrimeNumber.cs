using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeCalculator
{
    public class PrimeNumber
    {
        public bool IsPrime(int number)
        {
            if (number < 2)
                return false;

            for (int i = 2; i * i <= number; i++)
                if (number % i == 0)
                    return false;

            return true;
        }
    }
}
