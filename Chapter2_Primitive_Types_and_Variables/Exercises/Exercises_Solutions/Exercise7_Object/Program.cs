using System;
/* Question:
 * Declare two variables of type string with values "Hello" and "World". Declare a variable of type object.
 * Assign the value obtained of concatenation of the two string variables (add space if necessary) to this variable.
 * Print the variable of type object.
 */
namespace Exercise7_Object
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string helloContainer = "Hello";
            string worldContainer = "World";
            object bigContainer = helloContainer + " " + worldContainer;
            Console.WriteLine(bigContainer);
            /* Console Output:
             * Hello World
             */
        }
    }
}
