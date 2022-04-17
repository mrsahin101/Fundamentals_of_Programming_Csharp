using System;

namespace Example2_Floats
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float FloatPI = 3.14f;
            Console.WriteLine(FloatPI);
            /*Console output : 
             * 3,14
             */


            double DoublePI = 3.14;
            Console.WriteLine(DoublePI);
            /*Console output : 
             * 3,14
             */


            double nan = Double.NaN;
            Console.WriteLine(nan);
            /*Console output : 
             * NaN
             */


            double infinity = double.PositiveInfinity;
            Console.WriteLine(infinity);
            /*Console output : 
             * ?
             */
        }
    }
}
