using System;

/* Question : 
 * Declare several variables by selecting for each one of them the most appropriate of the types
 * sbyte, byte, short, ushort, int, uint, long and ulong in order to assign them the following values:
 * 52,130; -115; 4825932; 97; -10000; 20000; 224; 970,700,000; 112; -44; -1,000,000; 1990; 123456789123456789.
 */

namespace Exercise1_Variable_Declaration
{
    internal class Program
    {
        static void Main(string[] args)
        {

            float firstFloat = 52.130f;
            sbyte firstSByte = -115;
            uint firstUInt = 4825932;
            byte firstByte = 97;
            short firstShort = -10000;
            ushort firstUShort = 20000;
            byte secondByte = 224;
            uint secondUInt = 970700000;
            byte thirdByte = 112;
            sbyte secondSByte = -44;
            int thirdInt = -1000000;
            ushort secondUShort = 1990;
            ulong firstULong = 123456789123456789;
        }
    }
}
