using System;

namespace _010_Multiple_Labels
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 6;
            
            switch(number)
            {
                // case 1,4,6,8,10 all execute same thing. Console.WriteLine("This number is not prime!"); this line.
                case 1:
                case 4:
                case 6:
                case 8:
                case 10:
                    Console.WriteLine("This number is not prime!"); break;
                // case 2,3,5,7 all execute same thing. Console.WriteLine("This number is prime!"); this line.
                case 2:
                case 3:
                case 5:
                case 7:
                    Console.WriteLine("This number is prime!"); break;
                default:
                    Console.WriteLine("Unknown number"); break;

                /* Console output : This number is not prime!
                 */
            }
        }
    }
}
