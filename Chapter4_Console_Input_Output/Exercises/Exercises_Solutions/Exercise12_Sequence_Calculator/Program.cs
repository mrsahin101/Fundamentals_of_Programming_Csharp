using System;
/* Question : Write a program that calculates the sum (with precision of 0.001) of the following sequence: 
 * 1 + 1/2 - 1/3 + 1/4 - 1/5 + …
 */
namespace Exercise12_Sequence_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float sum = 1;
            float previous = 1;
            int i = 2;
            while(true)
            {
                if(i % 2 == 0)
                    sum += 1/(float)i;
                else
                    sum -= 1/(float)i;
                i++;
                if (Math.Abs(sum-previous) < 0.001)
                    break;
                previous = sum;
            }
            Console.WriteLine("Sequence sum : " + sum);
        }
    }
}
