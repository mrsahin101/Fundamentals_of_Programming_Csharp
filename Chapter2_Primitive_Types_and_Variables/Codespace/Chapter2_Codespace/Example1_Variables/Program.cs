using System;

namespace Example1_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Declare some variables */
            byte centuries = 20;
            ushort years = 2000;
            uint days = 730480;
            ulong hours = 17531520;

            /* Print the result on the console */
            Console.WriteLine(centuries + " centuries are " + years + " years, or " + days + " days, or " + hours + " hours.");

            /*Console Output: */
            /*20 centuries are 2000 years, or 730480 days, or 17531520 hours. */



            /* ulong example */
            ulong maxUlongValue = UInt64.MaxValue;
            Console.WriteLine("Maximum Unsigned Long value is :" + maxUlongValue);

            /* Console Output: */
            /* Maximum Unsigned Long value is :18446744073709551615 */
        }
    }
}
