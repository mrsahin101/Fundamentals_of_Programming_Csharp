using System;

namespace _002_Comparison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("char 'a' == 'a' ? " + ('a' == 'a'));
            /* Console Output :  char 'a' == 'a' ? True
             */

            Console.WriteLine("char 'a' == 'b' ? " + ('a' == 'b'));
            /* Console Output :  char 'a' == 'b' ? False
             */

            Console.WriteLine("5 != 6 :" + (5 != 6));
            /* Console Output :  5 != 6 :True
             */
            Console.WriteLine("5.0 == 5L :" + (5.0 == 5L));
            /* Console Output :  5.0 == 5L :True
             */
            Console.WriteLine("true == false ? :" + (true == false));
            /* Console Output :  true == false ? : False
             */
        }
    }
}
