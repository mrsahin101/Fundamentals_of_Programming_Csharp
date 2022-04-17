using System;

namespace Exercise10_Squence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Write a program that prints the first 100 members of the sequence 2, -3, 4, -5, 6, -7, 8...  */
            int indexNumber = 0;
            for (int i = 0; i < 100; i++)
            {
                indexNumber = i +2;
                if (indexNumber % 2 == 0)
                    Console.WriteLine(indexNumber);
                else
                    Console.WriteLine(indexNumber * (-1));
            }
        }
    }
}
