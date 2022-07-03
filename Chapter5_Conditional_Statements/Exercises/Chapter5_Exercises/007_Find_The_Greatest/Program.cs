using System;
/* Question :Write a program that finds the greatest of given 5 numbers.
 */
namespace _007_Find_The_Greatest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5] { 10, 2, 13, 17, 4, };

            int biggestnumber = numbers[0];

            for(int i = 1; i < 5; i++)
            {
                if(numbers[i] > biggestnumber)
                    biggestnumber = numbers[i];
            }
            Console.WriteLine("Biggest Number :" + biggestnumber);

        }
    }
}
