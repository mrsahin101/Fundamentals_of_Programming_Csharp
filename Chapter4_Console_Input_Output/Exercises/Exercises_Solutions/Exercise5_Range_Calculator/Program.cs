using System;
using System.Collections.Generic;
/* Question : Write a program that reads from the console two integer numbers (int) and prints how many numbers between them exist,
* such that the remainder of their division by 5 is 0. 
* Example: in the range (14, 25) there are 3 such numbers: 15, 20 and 25.
*/
namespace Exercise5_Range_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("First number :");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.Write("Second number :");
            int secondNumber = int.Parse(Console.ReadLine());

            List<int> list = FindDivisbleByFive(firstNumber, secondNumber);

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("List of range values :");
            foreach(int item in list)
                Console.WriteLine(item);
        }
        static List<int> FindDivisbleByFive(int firstNumber,int secondNumber)
        {
            List<int> result = new List<int>();
            int swapper = firstNumber;
            if(secondNumber < firstNumber)
            {
                firstNumber = secondNumber;
                secondNumber = firstNumber;
            }
            for(int i = firstNumber; i <= secondNumber; i++)
            {
                if(i % 5 == 0)
                    result.Add(i);
            }
            
            return result;
        }
    }
}
