using System;

namespace _001_Comparison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int weight = 700;
            Console.WriteLine(weight >= 500);
            /* Console Output : True
             */

            char gender = 'm';
            Console.WriteLine(gender <= 'f');
            /* Console Output : False
             */

            double colorWaveLength = 1.630;
            Console.WriteLine(colorWaveLength > 1.621);
            /* Console Output : True
             */

            int a = 5;
            int b = 7;
            bool condition = (b> a) && (a+b < a*b);
            Console.WriteLine(condition);
            /* Console Output : True
             */

            Console.WriteLine('B' == 'A' + 1);
            /* Console Output : True
             */

        }
    }
}
