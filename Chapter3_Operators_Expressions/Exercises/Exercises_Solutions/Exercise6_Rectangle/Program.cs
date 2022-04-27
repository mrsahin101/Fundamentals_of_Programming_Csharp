using System;
/* Question:
 * Write a program that prints on the console the perimeter and the area of a rectangle by given side and height entered by the user.
 */
namespace Exercise6_Rectangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Rectangle Perimeter Calculator!");

            string length = "a";
            int lenVal;
            int result = 0;
            /* Until user provide int.parsable value */
            while (!int.TryParse(length, out result))
            {
                Console.Write("Please Enter Length value for Rectangle(l) :");
                length = Console.ReadLine();
            }
            lenVal = result;

            string width = "b";
            int widthVal;

            while (!int.TryParse(width, out result))
            {
                Console.Write("Please Enter Width value for Rectangle(w) :");
                width = Console.ReadLine();
            }
            widthVal = result;

            int perimeter = 2 * (lenVal + widthVal);

            Console.WriteLine("Perimeter for this Rectangle is : " + perimeter.ToString());
        }
    }
}
