using System;
/* Question:
 * Declare a variable of type char and assign it as a value the character,
 * which has Unicode code, 72 (use the Windows calculator in order to find hexadecimal representation of 72).
 */
namespace Exercise5_HexChar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char myChar = '\u0048';
            Console.WriteLine(myChar);
            /* Console Output:
             * H
             */
        }
    }
}
