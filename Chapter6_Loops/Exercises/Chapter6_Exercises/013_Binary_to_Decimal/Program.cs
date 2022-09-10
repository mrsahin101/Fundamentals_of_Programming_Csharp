/* Write a program that converts a given number from binary to decimal notation.
*/
Console.Write("Enter binary :");
string binary = Console.ReadLine();
int converted = 0;

for (int i = binary.Length - 1, counter = 0; i >= 0; i--, counter++)
{
    if(binary[i] == '1')
    {
        converted += (int)Math.Pow(2,counter);
    }
}
Console.WriteLine("Decimal : " + converted);
