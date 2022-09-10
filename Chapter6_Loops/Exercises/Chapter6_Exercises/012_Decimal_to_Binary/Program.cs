/* Write a program that converts a given number from decimal to binary
notation (numeral system).
*/
using System.Text;

Console.Write("n :");
int n = int.Parse(Console.ReadLine());

StringBuilder bin = new StringBuilder();

for(int i = 31; i >= 0; i--)
{
    if (n >= Math.Pow(2, (double)i))
    {
        bin.Append("1");
        n -= (int) Math.Pow(2, (double)i);
    }
    else
        bin.Append("0");
}
string result = bin.ToString();
Console.WriteLine(result);