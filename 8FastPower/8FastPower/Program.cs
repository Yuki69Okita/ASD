using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8FastPower
{
    /// <summary>
    /// A program which makes fast calculation of x ^ n
    /// The complexity is log(n)
    /// </summary>
    class Program
    {
        static double Power(double x, int n) // x^n
        {
            if (n < 0)
            {
                throw new ApplicationException("n must be a positive integer or zero");
            }
            if (n == 0) return 1;
            if (n == 1) return x;

            if (n % 2 == 0)
            {
                return Power(x * x, n / 2);
            }
            else // n % 2 == 1
            {
                return x * Power(x * x, n / 2);
            }
        }

        static void Main(string[] args)
        {
            double res = Power(2, 5);
            Console.WriteLine("2^5 is {0}", res);

            res = Power(2, 10);
            Console.WriteLine("2^10 is {0}", res);
        }
    }
}
