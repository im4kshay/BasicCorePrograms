using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    class PrimeFactorization
    {
        public int j = 0;
        public int num = 0;
        public int factorial = 1;
        public void CalcSFactorialSeries()
        {
            Console.Write("Calculate the factorial of a given number:"); //Input From User
            num = Convert.ToInt32(Console.ReadLine());//reading input form user
            for (j = 1; j <= num; j++) //Checking var_j is <= num example(1<5) and den incrementing it by 1 
                factorial *= j; //calculate  factorial = factorial * var_j example (factroial = 1*1 or 2*2 or 5*5)
            Console.Write("The Factorial of {0} is: {1}\n", num, factorial); //op
        }
    }
}
