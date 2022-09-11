/* Write a program that converts a given number from decimal to hexadecimal notation.
*/
using System.Text;

Console.Write("n :");
int n = int.Parse(Console.ReadLine());

StringBuilder bin = new StringBuilder();

int digit = 0;
for (int i = 7; i >= 0; i--)
{
    if (n >= Math.Pow(16, (double)i))
    {
        digit = (int)(n / Math.Pow(16, (double)i));
        if (digit < 10)
            bin.Append(digit.ToString());
        else if (digit == 10)
            bin.Append("A");
        else if (digit == 11)
            bin.Append("B");
        else if (digit == 12)
            bin.Append("C");
        else if (digit == 13)
            bin.Append("D");
        else if (digit == 14)
            bin.Append("E");
        else if (digit == 15)
            bin.Append("F");

        n -= digit *(int)Math.Pow(16, (double)i);
    }
    else
        bin.Append("0");
}
string result = bin.ToString();
Console.WriteLine(result);