using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    class PrimeFactorization
    {
        int a, b;
        public void CalcSFactorialSeries()
        {
            Console.WriteLine("Please enter your integer: ");
            a = int.Parse(Console.ReadLine());
            for (b = 1; b <= a; b++)
            {
                if (a % b == 0)
                {
                Console.WriteLine(b + " is a factor of " + a);
                }
            }
    }
}
