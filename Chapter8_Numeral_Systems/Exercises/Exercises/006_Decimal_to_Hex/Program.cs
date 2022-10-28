/* Write a program that converts a decimal number to hexadecimal one. */
using System.Text;

void convert_to_Hex(int number)
{
    StringBuilder myStr = new StringBuilder();
    string[] myHexDigits = new string[]
    {
        "0","1","2","3","4","5","6","7","8","9","A","B","C","D","E","F",
    };
    while (number != 0)
    {
        int digit = number % 16;
        number /= 16;
        myStr.Insert(0, myHexDigits[digit]);
    }
    Console.Write(myStr.ToString());
    Console.WriteLine();
}
convert_to_Hex(45);