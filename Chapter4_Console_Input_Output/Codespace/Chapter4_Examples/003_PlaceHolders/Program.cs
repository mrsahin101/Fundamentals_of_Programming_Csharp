using System;

namespace _003_PlaceHolders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "Hello World";

            // Prints normal way
            Console.Write(str);
            /* Console Output : Hello World */

            // Prints through formatting string
            Console.Write("{0}", str);
            /* Console Output : Hello World*/


            string name = "John";
            int age = 18;
            string town = "Seattle";
            Console.Write("{0} is {1} years old from {2}!\n",name,age, town);
            /* Console Output : John is 18 years old from Seattle! */
        }
    }
}
