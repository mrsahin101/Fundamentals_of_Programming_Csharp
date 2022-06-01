using System;
/* Question : Write a program that exchanges the values of the bits on positions
 * 3, 4 and 5 with bits on positions 24, 25 and 26 of a given 32-bit unsigned integer. 
 *
 */
namespace Exercise15_Bit_Swapping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UInt32 myNumber = rnd32();
            myNumber = 100;
            Console.WriteLine("Generated random Number :" + myNumber);
            
            UInt32 result = Swapper(myNumber, 3, 24);
            result = Swapper(result, 4, 25);
            result = Swapper(result, 5, 26);

            Console.WriteLine("Result is : " + result);

        }
        private static uint rnd32()
        {
            Random rnd = new Random();
            return (uint)(rnd.Next(1 << 30)) << 2 | (uint)(rnd.Next(1 << 2));
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
