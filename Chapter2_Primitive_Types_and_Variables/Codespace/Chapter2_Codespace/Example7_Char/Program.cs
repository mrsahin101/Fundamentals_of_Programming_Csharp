using System;

namespace Example7_Char
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Declare char variable */
            char ch = 'a';

            /* Print out the result on the console */
            Console.WriteLine("The code of " + ch + " is " + (int)ch );
            /* Console Output: 
             * The code of a is 97 */

            /* Assign new value to ch */
            ch = 'b';
            Console.WriteLine("The code of " + ch + " is " + (int)ch);
            /* Console Output: 
             * The code of a is 98 */

            /* Assign new value to ch */
            ch = 'A';
            Console.WriteLine("The code of " + ch + " is " + (int)ch);
            /* Console Output: 
             * The code of a is 65 */
        }
    }
}
