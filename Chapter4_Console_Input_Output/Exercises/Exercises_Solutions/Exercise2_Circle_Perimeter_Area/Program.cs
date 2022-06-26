using System;
/* Question : Write a program that reads from the console the radius "r" of a circle and prints its perimeter and area.
 */
namespace Exercise2_Circle_Perimeter_Area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Radius (r) : ");
            int radius = int.Parse(Console.ReadLine());
            // perimeter formula = 2 x pi x radius
            Console.WriteLine("Perimeter : " + (2 * Math.PI * radius));
            // Area formula = pi x radius square
            Console.WriteLine("Area :" + (Math.PI * radius * radius));
        }
    }
}
