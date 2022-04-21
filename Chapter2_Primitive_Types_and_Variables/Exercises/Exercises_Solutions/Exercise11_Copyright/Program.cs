using System;
/* Question:
 * Write a program that prints on the console isosceles triangle which sides consist of the copyright character "©".
 */
namespace Exercise11_Copyright
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ch = "\u00A9";
            Console.WriteLine("   " + ch + "   ");
            Console.WriteLine("  " + ch + " " + ch + "  ");
            Console.WriteLine(" " + ch + "   " + ch + " ");
            Console.WriteLine(ch + " " +  ch + " " + ch + " "  + ch);
            /* Console Output : 
             *    ©
                 © ©
                ©   ©
               © © © ©
            */
        }
    }
}
