using System;
/* Question :We are given 5 integer numbers. Write a program that finds those subsets whose sum is 0. Examples:
- If we are given the numbers {3, -2, 1, 1, 8}, the sum of -2, 1 and 1 is 0.
- If we are given the numbers {3, 1, -7, 35, 22}, there are no subsets with sum 0.
*/
namespace _009_Sums_Zero
{
    internal class Program
    {
        /* ALL COMBINATIONS.
         * 
         * 1 category          2 categories             3 categories            4 categories        5 categories
         *      A                   AB                      ABC                     ABCD                ABCDE
         *      B                   AC                      ABD                     ABCE
         *      C                   AD                      ABE                     ABDE
         *      D                   AE                      ACD                     ACDE
         *      E                   BC                      ACE                     BCDE
         *                          BD                      ADE
         *                          BE                      BCD
         *                          CD                      BCE
         *                          CE                      BDE
         *                          DE                      CDE
         *
         */
        static void Main(string[] args)
        {
            int A = 3;
            int B = -2;
            int C = 1;
            int D = 1;
            int E = 8;
            // 1 CATEGORY
            if (A == 0)
                Console.WriteLine("A == 0");
            else if (B == 0)
                Console.WriteLine("B == 0");
            else if (C == 0)
                Console.WriteLine("C == 0");
            else if (D == 0)
                Console.WriteLine("D == 0");        
            else if (E == 0)
                Console.WriteLine("E == 0");
            // 2 CATEGORIES
            if((A+B ) == 0)
                Console.WriteLine("A + B = 0");
            else if ((A+C) == 0)
                Console.WriteLine("A + C = 0");
            else if ((A+D) == 0)
                Console.WriteLine("A + D = 0");
            else if ((A+E) == 0)
                Console.WriteLine("A + E = 0");
            else if ((B+C) == 0)
                Console.WriteLine("B + C = 0");
            else if ((B+D) == 0)
                Console.WriteLine("B + D = 0");
            else if ((B+E) == 0)
                Console.WriteLine("B +E = 0");
            else if ((C+D) == 0)
                Console.WriteLine("C + D = 0");
            else if ((C+E) == 0)
                Console.WriteLine("C + E = 0");
            else if ((D+E) == 0)
                Console.WriteLine("D +E = 0");
            // 3 CATEGORIES
            if ((A + B + C) == 0)
                Console.WriteLine("A + B + C = 0");
            else if ((A + B + D) == 0)
                Console.WriteLine("A + B + D = 0");
            else if ((A + B + E) == 0)
                Console.WriteLine("A + B + E = 0");
            else if ((A + C + D) == 0)
                Console.WriteLine("A + C + D = 0");
            else if ((A + C + E) == 0)
                Console.WriteLine("A + C + E = 0");
            else if ((A + D + E) == 0)
                Console.WriteLine("A + D + E = 0");
            else if ((B + C + D) == 0)
                Console.WriteLine("B + C + D = 0");
            else if ((B + C + E) == 0)
                Console.WriteLine("B + C + E = 0");
            else if ((B + D + E) == 0)
                Console.WriteLine("B + D + E = 0");
            else if ((C + D + E) == 0)
                Console.WriteLine("C + D + E = 0");
            // 4 CATEGORIES
            if ((A +B + C + D) == 0)
                Console.WriteLine("A + B + C +D = 0");
            else if ((A + B + C + E) == 0)
                Console.WriteLine("A + B + C + E = 0");
            else if ((A + B + D + E) == 0)
                Console.WriteLine("A + B + D + E = 0");
            else if ((A + C + D + E) == 0)
                Console.WriteLine("A + C + D + E = 0");
            else if ((B + C + D + E) == 0)
                Console.WriteLine("B + C + D + E = 0");

            // 5 CATEGORIES
            if ((A + B + C + D + E) == 0)
                Console.WriteLine("A + B + C + D + E = 0");

        }
    }
}
