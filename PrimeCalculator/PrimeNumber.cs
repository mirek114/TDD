using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeCalculator
{
    public class PrimeNumber
    {
        private int actualNumber;
        private ulong sum;

        public bool IsPrime(int number)
        {
            if (number < 2)
                return false;

            for (int i = 2; i * i <= number; i++)
                if (number % i == 0)
                    return false;

            return true;
        }

        public ulong GetSumOfPrime(int range)
        {
            for (actualNumber = 2; actualNumber <= range; actualNumber++)
                if (IsPrime(actualNumber))
                    sum += Convert.ToUInt64(actualNumber);

            return sum;
        }
    }
}
