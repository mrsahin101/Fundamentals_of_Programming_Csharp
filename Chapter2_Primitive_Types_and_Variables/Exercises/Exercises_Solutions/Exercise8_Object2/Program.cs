using System;
/* Question:
 * Declare two variables of type string and give them values "Hello" and "World".
 * Assign the value obtained by the concatenation of the two variables of type string
 * (do not miss the space in the middle) to a variable of type object.
 * Declare a third variable of type string and initialize it with the value of the variable of type object 
 * (you should use type casting).
 */
namespace Exercise8_Object2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string helloContainer = "Hello";
            string worldContainer = "World";
            object BigContainer = helloContainer + " " + worldContainer;
            string strBigContainer = (string)BigContainer;
            Console.WriteLine(strBigContainer);
            /* Console Output :
             * Hello World
             */
        }
    }
}
