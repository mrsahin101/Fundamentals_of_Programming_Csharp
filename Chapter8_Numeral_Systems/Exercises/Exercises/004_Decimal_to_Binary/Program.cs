/* Write a program that converts a decimal number to binary one. */

using System.Text;

void convert_decimal_to_binary(int number)
{
    StringBuilder myStr = new StringBuilder();
    while (number != 0)
    {
        int digit = number % 2;
        number /= 2;
        myStr.Insert(0, digit.ToString());
    }
    Console.Write(myStr.ToString());
    Console.WriteLine();
}
convert_decimal_to_binary(10);