using System;

namespace _002_String_Concatenation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "Four : " + 2 + 2;
            Console.WriteLine(s);
            /* Console Output : Four : */

            string s1 = "Four :" + (2+2);
            Console.WriteLine(s1);
            /* Console Output : Four : 4 */
        }
    }
}
