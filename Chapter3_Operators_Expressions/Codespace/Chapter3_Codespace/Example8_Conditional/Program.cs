using System;

namespace Example8_Conditional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 6;
            int b = 4;
            Console.WriteLine(a > b ? "a > b" : "b <= a");
            /* Console Output:
             * a > b
             */

            int num = a == b ? 1 : -1;
            Console.WriteLine(num);
            /* Console Output:
             * -1
             */

            /* DOT OPERATOR */
            Console.WriteLine(DateTime.Now);
            /* Console Output:
             * 24.04.2022 20:07:52 // This is current date
             */

            /* SQUARE BRACKETS[] OPERATOR */
            int[] arr = { 1, 2, 3 };
            Console.WriteLine(arr[0]);
            /* Console Output:
             * 1
             */

            string str = "Hello";
            Console.WriteLine(str[1]);
            /* Console Output:
             * e
             */

            /* OPERATOR "??" */
            int? x = 5;
            Console.WriteLine(x ?? -1);
            /* Console Output:
             * 5
             */

            string name = null;
            Console.WriteLine(name ?? "no name");
            /* Console Output:
             * no name
             */

            /* SOME EXAMPLES FOR OPERATORS */
            int k = 6;
            int l = 3;

            Console.WriteLine(k + l / 2);
            /* Console Output:
             * 7
             */

            Console.WriteLine((k + l) / 2);
            /* Console Output:
             * 4
             */

            string s = "Beer";
            Console.WriteLine(s is string);
            /* Console Output:
             * True
             */

            string notNullString = s;
            string nullString = null;

            Console.WriteLine(nullString ?? "Unspecified");
            /* Console Output:
             * Unspecified
             */

            Console.WriteLine(notNullString ?? "Unspecified");
            /* Console Output:
             * Beer
             */
        }
    }
}
