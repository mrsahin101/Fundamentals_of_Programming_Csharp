/* Convert the hexadecimal numbers FA, 2A3E, FFFF, 5A0E9 to binary and decimal numeral systems. 
 */

using System.Text;

void convert_to_Decimal(int number)
{
    Console.Write(number);
    Console.WriteLine();
}
void convert_to_Binary(int x)
{
    StringBuilder myStr = new StringBuilder();
    while (x != 0)
    {
        int digit = x % 2;
        x /= 2;
        myStr.Insert(0, digit.ToString());
    }
    Console.Write(myStr.ToString());
    Console.WriteLine();
}
convert_to_Binary(0xFA);
convert_to_Binary(0x2A3E);
convert_to_Binary(0xFFFF);
convert_to_Binary(0x5A0E9);

convert_to_Decimal(0xFA);
convert_to_Decimal(0x2A3E);
convert_to_Decimal(0xFFFF);
convert_to_Decimal(0x5A0E9);