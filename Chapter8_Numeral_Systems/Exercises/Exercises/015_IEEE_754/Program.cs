/* * Write a program that prints the value of the mantissa,
 * the sign of the mantissa and exponent in float numbers
 * (32-bit numbers with a floating-point according to the IEEE 754 standard).
 * Example: for the number -27.25 should be printed: 
 * sign = 1, exponent = 10000011, mantissa = 10110100000000000000000. 
 */
void printOut_Mantissa(float floatNumber)
{
    byte[] myBytes = new byte[4];

    myBytes = BitConverter.GetBytes(floatNumber);
    Console.WriteLine("Sign : " + (myBytes[3] >> 7) + " exponent : " +
    Convert.ToString(((myBytes[3] << 1)+ (myBytes[2] >> 7)), 2) + " mantissa : " +
    Convert.ToString((myBytes[2] & 0x7F), 2).PadLeft(7, '0') + Convert.ToString(myBytes[1], 2).PadLeft(8, '0')
    + Convert.ToString(myBytes[0], 2).PadLeft(8, '0'));
}
float myFloatNumber = 3.1415f;
printOut_Mantissa(myFloatNumber);



