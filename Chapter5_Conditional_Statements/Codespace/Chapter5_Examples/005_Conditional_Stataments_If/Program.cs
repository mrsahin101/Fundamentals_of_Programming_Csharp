using System;

namespace _005_Conditional_Stataments_If
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Two numbers");
            Console.Write("Enter First number :");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter Second number :");
            int secondNumber = int.Parse(Console.ReadLine());

            int biggerNumber = firstNumber;
            if(secondNumber > firstNumber)
            {
                biggerNumber = secondNumber;
            }
            Console.WriteLine("The bigger number is : {0}", biggerNumber);
            /* Console Output : The bigger number is : 10
             */

        }
    }
}
