using System;

namespace _004_Sort_Number_Descending_Order
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float firstNumber = 10;
            float secondNumber = 20;
            float thirdNumber = 30;

            if ( firstNumber == secondNumber)
            {
                if (firstNumber == thirdNumber)
                    Console.WriteLine("First number = Second number = Third number");
                else if (firstNumber > thirdNumber)
                    Console.WriteLine("First number = Second number > Third number");
                else
                    Console.WriteLine("First number = Second number < Third number");
            }
            else if (firstNumber > secondNumber)
            {
                if(firstNumber == thirdNumber)
                {
                    Console.WriteLine("First number = Third number > Second number ");
                }
                else if (firstNumber > thirdNumber)
                {
                    if (secondNumber == thirdNumber)
                        Console.WriteLine("First number > Second number = Third number");
                    else if (secondNumber > thirdNumber)
                        Console.WriteLine("First number > Second number > Third number");
                    else
                        Console.WriteLine("First number > Third number > Second number");
                }
                else
                    Console.WriteLine("Third number > First number > Second number ");
            }
            else // first < second
            {
                if(secondNumber == thirdNumber)
                    Console.WriteLine("Second number > Third number > First number");
                else if (secondNumber > thirdNumber)
                {
                    if (thirdNumber == firstNumber)
                        Console.WriteLine("Second number > Third number = First number");
                    else if (thirdNumber > firstNumber)
                        Console.WriteLine("Second number > Third number > First number");
                    else
                        Console.WriteLine("Second number > First number > Third number");
                }
                else  // second < third
                {
                    Console.WriteLine("Third number > Second number > First number");
                }

            }
        }
    }
}
