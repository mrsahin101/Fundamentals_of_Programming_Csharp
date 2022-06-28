using System;

namespace Exercise9_N_numbers_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many numbers you wanna sum (n) :");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for(int i = 0; i < n; i++)
            {
                Console.Write((i+1) + ".Number :");
                sum += int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Sum of " + n + " number is :" + sum);
        }
    }
}
