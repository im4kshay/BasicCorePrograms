using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    class FlipCoinHeadOrTail
    {
        public static void FindFlipCount()
        {
            int tailcount = 0, headcount = 0;
            Random random = new Random();
            Console.WriteLine("Enter nuber of times to flip a coin");
            int numbofTimes = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= numbofTimes; i++)
            {
                double input = random.NextDouble();
                if (input < 0.5)
                    tailcount++;
                else
                    headcount++;
            }
            Console.WriteLine("headcount:{0} tailcount:{1}", headcount, tailcount);
            double tailPercentage = (tailcount * 100) / numbofTimes;
            double headPercentage = (headcount * 100) / numbofTimes;
            Console.WriteLine("Head Percentage:{0}% Tail Percentage:{1}%", headPercentage, tailPercentage);
        }
    }
}
