using System;

namespace _012_Read
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int codeRead = 0;
            do
            {
                codeRead = Console.Read();
                if(codeRead != 0)
                    Console.WriteLine((char)codeRead);
            }
            while(codeRead != 10); // enter key unicode value
        }
    }
}
