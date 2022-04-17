using System;

namespace Example4_Floating_Errors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float floatnumber = 0.1f;
            Console.WriteLine(floatnumber);
            /* Console Output:
             * 0,1(CORRECT)*/


            double doublenumber = 0.1f;
            Console.WriteLine((doublenumber));
            /* Console Output:
             * 0,10000000149011612(INCORRECT: due to rounding)*/


            float secondfloatnumber = 1.0f / 3;
            Console.WriteLine(secondfloatnumber);
            /* Console Output:
             * 0,33333334(CORRECT: due to rounding)*/


            double seconddoublenumber = secondfloatnumber;
            Console.WriteLine(seconddoublenumber);
            /* Console Output:
             * 0,3333333432674408 (INCORRECT: due to rounding)*/
        }
    }
}
