using System;
using System.Text;
/* Question :Write a program that gets the coefficients a, b and c of a quadratic equation:
* ax2 + bx + c, calculates and prints its real roots (if they exist).
* Quadratic equations may have 0, 1 or 2 real roots.*/
namespace _006_Equation_Coefficents
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a :");
            double a  = double.Parse( Console.ReadLine());

            Console.Write("Enter b :");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Enter c :");
            double c = double.Parse(Console.ReadLine());

            double discriminant = (b * b) - (4 * a *c);

            if (discriminant == 0)
            {
                // has one root.
                Console.WriteLine("It has one real root : {0}", ((-b) / (2*a)));
            }
            else if (discriminant > 0)
            {
                Console.WriteLine("It has two real roots");
                Console.WriteLine("First root :{0}", (((-b) + Math.Sqrt((b*b) -(4*a*c))) / (2 * a)));
                Console.WriteLine("Second root :{0}", (((-b) - Math.Sqrt((b*b) -(4*a*c))) / (2 * a)));
            }
            else
                Console.WriteLine("It doesn't have real roots!");
        }

    }
}
