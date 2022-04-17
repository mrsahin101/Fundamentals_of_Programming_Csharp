using System;

namespace _003_Buggy_HelloCsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*We throw unimplemented exception so we can stimulate error case in our program.
             * so this is good way to learn about debugging.*/
            throw new NotImplementedException("My Intented Exception");
            Console.WriteLine("Hello World!");
        }
    }
}
