/* Convert the number 1111010110011110(2) to hexadecimal and decimal numeral systems. 
 */

using System.Text;

void convert_to_Hex(int number)
{
    StringBuilder myStr = new StringBuilder();
    string[] myHexDigits = new string[]
    {
        "0","1","2","3","4","5","6","7","8","9","A","B","C","D","E","F",
    };
    while(number != 0)
    {
        int digit = number % 16;
        number /= 16;
        myStr.Insert(0, myHexDigits[digit]);
    }
    Console.Write(myStr.ToString());
    Console.WriteLine();
}
void convert_to_Decimal(int number)
{
    StringBuilder myStr = new StringBuilder();
    while (number != 0)
    {
        int digit = number % 10;
        number /= 10;
        myStr.Insert(0, digit);
    }
    Console.Write(myStr.ToString());
    Console.WriteLine();
}
int binaryNumber = 0b1111010110011110;
convert_to_Hex(binaryNumber);
convert_to_Decimal(binaryNumber);