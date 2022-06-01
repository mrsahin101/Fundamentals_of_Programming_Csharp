using System;
/* Question : Write a program that exchanges bits {p, p+1, …, p+k-1} with bits
 * {q, q+1, …, q+k-1} of a given 32-bit unsigned integer. 
 */
namespace Exercise16_Bit_Swapper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UInt32 number;
            UInt32 arraySize = 0;
            UInt32[] pArray = new UInt32[32];
            UInt32[] qArray = new UInt32[32];
            bool errorFound = false;
            string pArraystr;
            string qArraystr;
            UInt32 result = 0;
            for (; ; )
            {
                Console.Write("Please enter unsigned number : ");
                string inputNumber = Console.ReadLine();
                if (UInt32.TryParse(inputNumber, out number))
                {
                    Console.Write("Please enter array size : ");
                    string inputArraySize = Console.ReadLine();
                    if (UInt32.TryParse(inputArraySize, out arraySize))
                    {
                        for(int i = 0; i < arraySize; i++)
                        {
                            Console.Write("Enter " + i + "th value for q: ");
                            pArraystr = (Console.ReadLine());
                            if (UInt32.TryParse(pArraystr, out pArray[i]) == false)
                            {
                                Console.WriteLine("Invalid Input");
                                errorFound = true;
                                break;
                            }
                                        
                            Console.Write("Enter " + i + "th value for q: ");
                            qArraystr = Console.ReadLine();
                            if (UInt32.TryParse(qArraystr, out qArray[i]) == false)
                            {
                                Console.WriteLine("Invalid Input");
                                errorFound = true;
                                break;
                            }
                        }
                        if(errorFound == false)
                        {
                            result = number;

                            for (int i = 0; i < arraySize;i++)
                            {
                                result = Swapper(result,pArray[i],qArray[i]);
                            }
                            Console.WriteLine("Calculated Result : " + result + "\n\n");
                        }
                    }
                    else
                        Console.WriteLine("Invalid input.");
                }
                else
                    Console.WriteLine("Invalid input.");

            }
        }
        private static UInt32 Swapper(UInt32 number, UInt32 indexOne, UInt32 indexTwo)
        {
            UInt32 junkBit = 1;
            UInt32 temporary = 0;
            UInt32 bitOne = 0;
            UInt32 bitSecond = 0;

            temporary = number >> (int)indexOne;
            bitOne = temporary & junkBit;
            /* temporaryBit equals bit of indexOneTh now*/

            bitSecond = number >> (int)indexTwo;
            bitSecond = bitSecond & 1;

            if (bitSecond == 0)
                number = number & ~(junkBit << (int)indexOne);
            else
                number = number | (junkBit << (int)indexOne);


            if (bitOne == 0)
                number = number & ~(junkBit << (int)indexTwo);
            else
                number = number | (junkBit << (int)indexTwo);

            return number;
        }
    }
}
