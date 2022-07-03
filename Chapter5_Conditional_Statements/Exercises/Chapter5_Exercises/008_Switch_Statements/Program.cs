using System;
/* Question :Write a program that, depending on the user’s choice, inputs int, double or string variable.
 * If the variable is int or double, the program increases it by 1.
 * If the variable is a string, the program appends "*" at the end.
 * Print the result at the console. Use switch statement.*/
namespace _008_Switch_Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter For int -> 0, for double -> 1, for string -> 2 ");
            Console.Write("Your choice :");
            int choice = int.Parse(Console.ReadLine()); 
            switch(choice)
            {
                case 0:
                    Console.WriteLine("Your choice is int");
                    Console.Write("Enter your int variable :");
                    int intVar = int.Parse(Console.ReadLine());
                    Console.WriteLine("End result: {0}", (intVar +1));
                    break;
                case 1:
                    Console.WriteLine("Your choice is double");
                    Console.Write("Enter your double variable :");
                    double doubleVar = double.Parse(Console.ReadLine());
                    Console.WriteLine("End result: {0}", (doubleVar +1));
                    break;
                case 2:
                    Console.WriteLine("Your choice is string");
                    Console.Write("Enter your string variable :");
                    string stringVar = Console.ReadLine();
                    Console.WriteLine("End result: {0}", (stringVar +"*"));
                    break;
                default:
                    Console.WriteLine("Unknown input");
                    break;
            }
        }
    }
}
