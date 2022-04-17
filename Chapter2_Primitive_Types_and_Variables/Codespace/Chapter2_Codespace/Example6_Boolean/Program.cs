using System;

namespace Example6_Boolean
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Declare variables */
            int numberOne = 1;
            int numberTwo = 2;

            /* Which one is greater? */
            bool greater = (numberOne > numberTwo);

            /* Is numberOne equal to 1 ? */
            bool equalOne = (numberOne == 1);

            /* Checking if greater == true */
            if (greater)
                Console.WriteLine("numberOne > numberTwo");
            else
                Console.WriteLine("numberOne <= numberTwo");

            Console.WriteLine("greater: " + greater);
            Console.WriteLine("equalOne: " + equalOne);

            /* Console Output:
             * numberOne <= numberTwo
             * greater: False
             * equalOne: True
             */
        }
    }
}
