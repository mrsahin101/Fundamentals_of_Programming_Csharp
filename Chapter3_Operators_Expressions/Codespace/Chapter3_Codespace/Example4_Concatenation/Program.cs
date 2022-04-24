using System;

namespace Example4_Concatenation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cSharp = "C#";
            string dotNet = ".NET";
            string cSharpdotNet = cSharp + dotNet;
            Console.WriteLine(cSharpdotNet);
            /* Console Output:
             * C#.NET
             */
            string cSharpdotNet4 = cSharpdotNet + " " + 5;
            Console.WriteLine(cSharpdotNet4);
            /* Console Output:
             * C#.NET 5
             */
        }
    }
}
