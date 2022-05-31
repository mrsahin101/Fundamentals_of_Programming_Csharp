using System;
/* Question : We are given the number n, the value v (v = 0 or 1) and the position p.
 * write a sequence of operations that changes the value of n, so the bit on the position p has the value of v.
 * Example: n=35, p=5, v=0 -> n=3. Another example: n=35, p=2, v=1 -> n=39.
 * 
 */
namespace Exercise13_Bit_Check2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int v, p, n, tempP;
            for(; ; )
            {
                Console.Write("Please enter value of n : ");
                string inputN = Console.ReadLine();

                Console.Write("Please enter value of v(0 or 1) : ");
                string inputV = Console.ReadLine();

                Console.Write("Please enter value of p : ");
                string inputP = Console.ReadLine();

                if (int.TryParse(inputN, out n) && int.TryParse(inputV, out v) && int.TryParse(inputP, out p) && (v == 0 || v == 1))
                {
                    tempP = ~(1 << p);
                    if (v == 0)
                        n = n & tempP;
                    else
                    {
                        tempP = 1 << p;
                        n = n | tempP;
                    }
                    Console.WriteLine("Calculated value : " + n);
                }
                else
                    Console.WriteLine("One of them is unparsable!.Try again");
                    

            }
        }
    }
}
