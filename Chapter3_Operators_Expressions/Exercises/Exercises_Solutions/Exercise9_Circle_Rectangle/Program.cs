using System;
/* Question : 
 * Write an expression that checks for given point {x, y} if it is within the circle K({0, 0}, R=5) and
 * out of the rectangle [{-1, 1}, {5, 5}]. 
 * Clarification: for the rectangle the lower left and the upper right corners are given.
 */

namespace Exercise9_Circle_Rectangle
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
            {
                if ((xVal <= 5 && xVal >= -1) && (yVal <= 5 && yVal >= 1))
                    Console.WriteLine("Inside the Circle and Rectangle!");
                else
                    Console.WriteLine("Inside the Circle, But Outside of Rectangle");
            }
            else
                Console.WriteLine("Outside of the Circle");
        }
    }
}
