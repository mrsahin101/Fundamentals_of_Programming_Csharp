/* Convert the numbers 151, 35, 43, 251, 1023 and 1024 to the binary numeral system.
 */
using System.Text;

void convert_to_Binary(int x)
{
    StringBuilder myStr = new StringBuilder();
    while (x != 0)
    {
        int digit = x % 2;
        x /= 2;
        myStr.Insert(0,digit.ToString());
    }
    Console.Write(myStr.ToString());
    Console.WriteLine();
}

convert_to_Binary(151);
convert_to_Binary(35);
convert_to_Binary(43);
convert_to_Binary(251);
convert_to_Binary(1023);
convert_to_Binary(1024);