using System;
/* Question : Write a program that reads five numbers from the console and prints the greatest of them.
 */
namespace Exercise8_FindGreatest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;

            int[] number = new int[5];
            for (int i = 0; i < 5; i++)
            {
                bas:
                Console.Write((i + 1) + ".Number :");
                input = Console.ReadLine();
                if (int.TryParse(input, out number[i]))
                {

                }
                else
                {
                    Console.WriteLine("Please try again!");
                    goto bas;
                }
            }
            Console.Write("Biggest number : ");
            Console.WriteLine(FindBiggest(number));
        }
        static int FindBiggest(int[] numbers)
        {
            int biggest = 0;

            for(int i = 0; i < numbers.Length; i++)
            {
                if(numbers[i] > biggest)
                    biggest = numbers[i];
            }

            return biggest;
        }
    }

}
