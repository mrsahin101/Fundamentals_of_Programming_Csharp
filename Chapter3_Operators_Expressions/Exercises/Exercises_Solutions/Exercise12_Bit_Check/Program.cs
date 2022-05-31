using System;
/* Question : Write a Boolean expression that checks if the bit on position p in the integer v has the value 1.
 * Example v=5, p=1 -> false.
 */

namespace Exercise12_Bit_Check
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int p = 0;
            int tempP = 0;
            int v = 0;
            for (; ; )
            {
                Console.Write("Please enter number p :");
                string inputP = Console.ReadLine();
                Console.Write("Please Enter number v: ");
                string inputV = Console.ReadLine();

                if(int.TryParse(inputV, out v) && int.TryParse(inputP, out p))
                {
                    tempP = 1 << p;
                    if ((v & tempP)  == 0)
                        Console.WriteLine("Number " + v + " " + p + "th bit is 0");
                    else
                        Console.WriteLine("Number " + v + " " + p + "th bit is 1");
                }
                else
                    Console.WriteLine("This is unparsable. Please enter integer!");

            }
        }
    }
}
