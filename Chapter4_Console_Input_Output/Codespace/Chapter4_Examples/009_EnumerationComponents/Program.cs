using System;

namespace _009_EnumerationComponents
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0:G}",DayOfWeek.Wednesday);
            /* Console Output : Wednesday*/
            Console.WriteLine("{0:D}", DayOfWeek.Wednesday);
            /* Console Output : 3*/
            Console.WriteLine("{0:X}", DayOfWeek.Wednesday);
            /* Console Output : 00000003*/
        }
    }
}
