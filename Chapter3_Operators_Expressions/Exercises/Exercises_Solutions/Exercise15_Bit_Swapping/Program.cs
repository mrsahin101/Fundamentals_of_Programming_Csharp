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
            Console.WriteLine("Generated random Number :" + myNumber);

            //UInt32 temp = 0;
            //UInt32 tempBit = 0;
            //temp = myNumber >> 3;
            //UInt32 junkBit = 1;
            //tempBit = temp & junkBit;



        }
        private static uint rnd32()
        {
            Random rnd = new Random();
            return (uint)(rnd.Next(1 << 30)) << 2 | (uint)(rnd.Next(1 << 2));
        }
    }
}
