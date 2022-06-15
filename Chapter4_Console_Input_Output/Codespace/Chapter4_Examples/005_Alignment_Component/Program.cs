using System;

namespace _005_Alignment_Component
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0,6}",123);
            Console.WriteLine("{0,6}", 1234);
            Console.WriteLine("{0,6}", 12);
            Console.Write("{0,-6}", 123);
            Console.WriteLine("--end");
            /* Console Output : 
             *   123
             *  1234
             *    12
             *123   --end
             */

        }
    }
}
