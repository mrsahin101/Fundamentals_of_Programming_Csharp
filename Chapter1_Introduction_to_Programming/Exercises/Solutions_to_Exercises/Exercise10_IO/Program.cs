using System;

namespace Exercise10_IO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Your Age:");
            string input = Console.ReadLine();

            Console.WriteLine("Your Age 10 years later :" + (int.Parse(input) + 10));
        }
    }
}
