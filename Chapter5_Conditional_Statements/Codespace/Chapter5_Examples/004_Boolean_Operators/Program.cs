using System;

namespace _004_Boolean_Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool result = (2 < 3) && (3 < 4);
            Console.WriteLine(result);
            /* Console Output : True
             */
            bool resultTwo = (2 < 3) || (1 == 2);
            Console.WriteLine(resultTwo);
            /* Console Output : True
             */
            Console.WriteLine("Exclusive OR :" + ((2 < 3) ^ (4 > 3))); // false because both true.
            /* Console Output : Exclusive OR :False
             */

            bool value = !(7 == 5);     // inside of parantesis is false. but when we apply ! , value will get true value.
            Console.WriteLine(value);
            /* Console Output : True
             */
        }
    }
}
