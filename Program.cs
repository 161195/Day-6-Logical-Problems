using System;

namespace logicalProblem_Day6
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your program name");

            Console.WriteLine("1.fibonacci\n2.perfect no\n3.prime no\n4.reverseNumber\n5.coupon\n6.stopwatch");
            int input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 1:
                    fibonacci play = new fibonacci();
                    play.checkSeries();
                    break;

                case 2:
                    perfectNo play1 = new perfectNo();
                    play1.checkPerfectNo();
                    break;

                case 3:
                    PrimeNo play3 = new PrimeNo();
                    play3.primeNoCheck();
                    break;

                case 4:
                    Reverse_No play4 = new Reverse_No();
                    play4.reverseNo();
                    break;

                case 5:
                    coupons_No play5 = new coupons_No();
                    play5.coupons();
                    break;

                case 6:
                    stopwatch play6 = new stopwatch();
                    play6.stopwatchRun();
                    break;













            }
        }
    }
}
