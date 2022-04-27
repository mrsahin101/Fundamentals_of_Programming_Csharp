using System;
/* Question:
 * Write an expression that calculates the area of a trapezoid by given sides a, b and height h.
 */
namespace Exercise5_Trapezoiz
{
    internal class Program
    {
        /* Formula for trapeziod is  Area = ((a+b) / 2 ) * h */
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to trapezoid calculator!");
            string aBase = "a";
            int aValue;
            int result = 0;
            /* Until user provide int.parsable value */
            while(!int.TryParse(aBase, out result))
            {
                Console.Write("Please Enter First Base value(a) :");
                aBase = Console.ReadLine();
            }
            aValue = result;

            string bBase = "b";
            int bValue = 0;
            while (!int.TryParse(bBase, out result))
            {
                Console.Write("Please Enter First Base value(b) :");
                bBase = Console.ReadLine();
            }
            bValue = result;

            string hBase = "h";
            int hValue = 0;
            while(!int.TryParse(hBase, out result))
            {
                Console.Write("Please Enter Height value(h) :");
                hBase = Console.ReadLine();
            }
            hValue = result;
            double Area = ((double)(aValue + bValue) / 2) * hValue;
            Console.WriteLine("Area of trapezoid for those values you have provided is : " + Area.ToString());

        }
    }
}
