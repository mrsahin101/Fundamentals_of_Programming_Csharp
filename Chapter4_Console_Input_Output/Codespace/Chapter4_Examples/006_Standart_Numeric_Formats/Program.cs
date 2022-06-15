using System;

namespace _006_Standart_Numeric_Formats
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // curreny formatter
            Console.WriteLine("{0:C2}",123.456);
            /* Console Output : ?123,46*/

            // integer formatter
            Console.WriteLine("{0:D6}", -1234);
            /* Console Output : -001234*/

            // Exponent formatter
            Console.WriteLine("{0:E2}", 123);
            /* Console Output : 1,23E+002*/

            // Integer or decimal formatter
            Console.WriteLine("{0:F2}", -123.456);
            /* Console Output : -123,462*/

            // Thousands and millions formatter
            Console.WriteLine("{0:N2}", 1234567.8);
            /* Console Output : 1.234.567,80*/

            // Percent formatter
            Console.WriteLine("{0:P}", 0.456);
            /* Console Output : %45,60*/

            // Hex formatter
            Console.WriteLine("{0:X}", 254);
            /* Console Output : FE*/
        }
    }
}
