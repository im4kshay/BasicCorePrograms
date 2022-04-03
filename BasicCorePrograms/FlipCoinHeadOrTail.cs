using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    class FlipCoinHeadOrTail
    {
        public static void FindFlipCoinCount()
        {
            int tailCount = 0, headCount = 0;
            Random random = new Random();
            Console.WriteLine("Enter number of times to flipcoin");
            int numbOfTimes = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= numbOfTimes; i++)
            {
                double input = random.NextDouble();
                if (input < 0.5)
                    tailCount++;
                else
                    headCount++;
            }
            Console.WriteLine("headCount:{0} tailCount:{1}", headCount, tailCount);
            double tailPercentage = (tailCount * 100) / numbOfTimes;
            double headPercentage = (headCount * 100) / numbOfTimes;
            Console.WriteLine("Head Percentage:{0}% tail Percentage:{1}%", headPercentage, tailPercentage);
        }
    }
}
