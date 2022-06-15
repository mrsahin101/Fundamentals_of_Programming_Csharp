using System;

namespace _004_out_Keyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int myValue = 1;
            int result = myFunction(5, out myValue);
            Console.WriteLine(result);
            Console.WriteLine(myValue);
        }
        static int myFunction(int a, out int b)
        {
            a++;
            b = a+1;
            return b * a;
        }
    }
}
