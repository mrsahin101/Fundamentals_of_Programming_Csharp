using System;
/* Question:
 * Initialize a variable of type int with a value of 256 in hexadecimal format (256 is 100 in a numeral system with base 16).
 */
namespace Exercise4_HexInit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int myVariable = 0x100;
            Console.WriteLine(myVariable);
            /* Console Output :
             * 256
             */
        }
    }
}
