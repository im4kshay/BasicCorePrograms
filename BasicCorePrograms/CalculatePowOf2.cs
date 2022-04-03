using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    class CalculatePowOf2
    {
        public int num = 0;
        public void CalcuOfPower()
        {

            Console.Write("Enter a number:");//input from User
            int num = Convert.ToInt32(Console.ReadLine());
            int result = num * num; //num*num if 12*12==144
            Console.WriteLine(result);//Op
            Console.ReadLine();
        }
    }
}
