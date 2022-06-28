using System;
/* Question : Write a program that prints on the console the first 100 numbers in the Fibonacci sequence:
 * 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, …
 *
 */
namespace Exercise11_Fibonacci_Sequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ulong now = 1;
            ulong previous = 0;
            ulong sumTemp = 0;

            Console.WriteLine(0 + "th number : " + previous);
            Console.WriteLine(0 + "th number : " + now);

            for(int i = 2; i <= 100;i++)
            {
                sumTemp = now +previous;
                previous = now;
                now = sumTemp;
                Console.WriteLine(i+ "th number :" + now);
            }
        }
    }
}
