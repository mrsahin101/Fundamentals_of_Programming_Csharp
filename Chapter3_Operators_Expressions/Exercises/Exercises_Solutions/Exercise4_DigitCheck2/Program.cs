using System;
/* Question :
 * Write an expression that checks whether the third bit in a given integer is 1 or 0.
 */
namespace Exercise4_DigitCheck2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(; ; )
            {
                string input = Console.ReadLine();
                if(int.TryParse(input, out int result))
                {
                    if ((result / 100 == 0 && (result/100) % 10 == 0) || (result / 100 == 1 && (result/100) % 10 ==1))
                        Console.WriteLine("Yes it is matched!");
                    else
                        Console.WriteLine("No match Found!");
                }
                else
                    Console.WriteLine("Invalid Input");
            }
        }
    }
}
