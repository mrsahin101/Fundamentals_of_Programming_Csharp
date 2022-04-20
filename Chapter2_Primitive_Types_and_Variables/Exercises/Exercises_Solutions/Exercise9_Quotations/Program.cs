using System;
/* Question:
 * Declare two variables of type string and assign them a value
 * “The "use" of quotations causes difficulties.” (without the outer quotes).
 * In one of the variables use quoted string and in the other do not use it.*/
namespace Exercise9_Quotations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstStr = "The \"use\" of quotations causes difficulties";
            Console.WriteLine(firstStr);
            /* Console Output:
             * The "use" of quotations causes difficulties
             */
            string secondStr = @"The " + "use" + " of quotations causes difficulties";
            /* Console Output:
             * The "use" of quotations causes difficulties
             */
        }
    }
}
