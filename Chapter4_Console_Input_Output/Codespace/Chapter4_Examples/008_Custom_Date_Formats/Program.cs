using System;

namespace _008_Custom_Date_Formats
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime d = new DateTime(2022, 06, 17, 21, 14, 30);
            Console.WriteLine("{0:dd/MM/yyyy HH:mm:ss}",d);
            /* Console output : 17.06.2022 21:14:30*/
            Console.WriteLine("{0:d.MM.yy}",d);
            /* Console output : 17.06.22*/
        }
    }
}
