using System;

namespace _007_Custom_Numeric_Formats
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0:0.00}", 1);
            /* Console Output : 1,00 */

            Console.WriteLine("{0:#.##}", 0.234);
            /* Console Output : ,23 */

            Console.WriteLine("{0:#####}", 12345.67);
            /* Console Output : 12346 */

            Console.WriteLine("{0:(0#) ### ## ##}", 29342525);
            /* Console Output : (02) 934 25 25 */

            Console.WriteLine("{0:%##}", 0.234);
            /* Console Output : %23 */
        }
    }
}
