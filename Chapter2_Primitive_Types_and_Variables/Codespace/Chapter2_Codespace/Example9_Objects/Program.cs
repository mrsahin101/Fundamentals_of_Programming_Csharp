using System;

namespace Example9_Objects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Declare some object type variables. */
            object container1 = 5;
            object container2 = "Five";

            /* Print the results on the console.*/
            Console.WriteLine("The value of container1 is : " + container1);
            Console.WriteLine("The value of container2 is : " + container2);
            /* Console Output: 
             * The value of container1 is : 5
             * The value of container2 is : Five
             */
        }
    }
}
