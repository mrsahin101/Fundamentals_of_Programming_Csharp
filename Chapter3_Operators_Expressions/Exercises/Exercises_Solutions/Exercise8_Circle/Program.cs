using System;
/* Question
 * Write an expression that checks for a given point {x, y} if it is within the circle K({0, 0}, R=5).
 * Explanation: the point {0, 0} is the center of the circle and 5 is the radius.
 */
namespace Exercise8_Circle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string xInput = "a";
            string yInput = "b";
            int xVal = 0;
            int yVal = 0;

            while (!int.TryParse(xInput, out xVal))
            {
                Console.Write("Please Enter x value : ");
                xInput = Console.ReadLine();
            }

            while (!int.TryParse(yInput, out yVal))
            {
                Console.Write("Please Enter x value : ");
                yInput = Console.ReadLine();
            }

            if ((xVal < 5 && xVal > -5) && (yVal < 5 && yVal > -5))
                Console.WriteLine("Given Point is in the Circle");
            else
                Console.WriteLine("False.Given point isnt in the Circle.Either on the circle or outside of it");

        }
    }
}
