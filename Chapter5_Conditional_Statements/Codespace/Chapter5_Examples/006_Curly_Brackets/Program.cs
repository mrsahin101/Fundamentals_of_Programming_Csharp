using System;

namespace _006_Curly_Brackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 6;
            if (a > 5)
                Console.WriteLine("The variable is greater than 5");
                Console.WriteLine("This code always will be executed!");
            // this way leads to confusion. Even when if is false second console.write always be executed!
            /* Console Output : The variable is greater than 5
                                This code always will be executed!
             */
        }
    }
}
