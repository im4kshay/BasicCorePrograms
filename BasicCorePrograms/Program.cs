using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Basic Core Programs ");
            Console.WriteLine("1 For: Flip a Coin Head and Tail.\n2 For: Select Value is Leap Year Or not.\n3 For: Select Power of 2 Number.\n4 For: Select the Harmonic Number.\n5 For: Select Factors of number.\n6 For: Select Quotient and Remainder.\n7 For: Select Swap the Numbers.\n8 For :Select Even and Odd number.\n9 For: Select Alphabet Vowel.\n10 For: Select Greatest number among Three.\n");
            int selection = Convert.ToInt32(Console.ReadLine());

            //User Selection
            switch (selection)
            {
                case 1:
                    //FLIP COIN
                    FlipCoinHeadOrTail.FindFlipCoinCount();
                    break;
                case 2:
                    //LEAP YEAR
                    CheckLeapYear LeapYearOrNot = new CheckLeapYear();
                    LeapYearOrNot.LeapYear();
                    break;
                case 3:
                    //POWER OF 2
                    CalculatePowOf2 CalPower = new CalculatePowOf2();
                    CalPower.CalcuOfPower();
                    break;
                case 4:
                    //HARMONIC SERIES
                    HarmonicNumber CalculateHarmonicNumber = new HarmonicNumber();
                    CalculateHarmonicNumber.CalcHarmonicSeries();
                    break;
                case 5:
                    //PRIME FACTOR
                    PrimeFactorization PrimeFactor = new PrimeFactorization();
                    PrimeFactor.CalcSFactorialSeries();
                    break;
                case 6:
                    //QUOTIENT REMAINDER
                    QuotientRemainder QuesRem = new QuotientRemainder();
                    QuesRem.GetQuotientRemainder();
                    break;
                case 7:
                    //SWAP NUMBERS
                    SwapNumbers swap = new SwapNumbers();
                    swap.SwapTwoNumbers();
                    break;
                case 8:
                    //EVEN OR ODD
                    EvenOrOdd EvenOdd = new EvenOrOdd();
                    EvenOdd.CheckEvenOrdd();
                    break;
                case 9:
                    //VOWEL OR NOT
                    VowelOrNot VowelNot = new VowelOrNot();
                    VowelNot.CheckGivenVowel();
                    break;
                case 10:
                    //GREATER AND SMALLER
                    GreaterOrSmaller checkgreaterOrSmallest = new GreaterOrSmaller();
                    checkgreaterOrSmallest.GetGreaterOrSmaller();
                    break;
                default:
                    Console.WriteLine("Invalid Selection. Select in Between 1 to 10");
                    break;
            }
            Console.ReadLine();
        }
    }
}
