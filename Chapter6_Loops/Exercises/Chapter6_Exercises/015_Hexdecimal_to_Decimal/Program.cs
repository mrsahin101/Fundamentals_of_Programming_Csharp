/* Write a program that converts a given number from hexadecimal to
decimal notation.
*/

Console.Write("Enter hex :");
string binary = Console.ReadLine();
int converted = 0;

for (int i = binary.Length - 1, counter = 0; i >= 0; i--, counter++)
{
    if (binary[i] == '1')
    {
        converted += (int)Math.Pow(16, counter);
    }
    else if (binary[i] == '2')
    {
        converted += 2 * (int)Math.Pow(16, counter);
    }
    else if (binary[i] == '3')
    {
        converted += 3 * (int)Math.Pow(16, counter);
    }
    else if (binary[i] == '4')
    {
        converted += 4 * (int)Math.Pow(16, counter);
    }
    else if (binary[i] == '5')
    {
        converted += 5 * (int)Math.Pow(16, counter);
    }
    else if (binary[i] == '6')
    {
        converted += 6 * (int)Math.Pow(16, counter);
    }
    else if (binary[i] == '7')
    {
        converted += 7 * (int)Math.Pow(16, counter);
    }
    else if (binary[i] == '8')
    {
        converted += 8 * (int)Math.Pow(16, counter);
    }
    else if (binary[i] == '9')
    {
        converted += 9 * (int)Math.Pow(16, counter);
    }
    else if (binary[i] == 'A')
    {
        converted += 10 * (int)Math.Pow(16, counter);
    }
    else if (binary[i] == 'B')
    {
        converted += 11 * (int)Math.Pow(16, counter);
    }
    else if (binary[i] == 'C')
    {
        converted += 12 * (int)Math.Pow(16, counter);
    }
    else if (binary[i] == 'D')
    {
        converted += 13 * (int)Math.Pow(16, counter);
    }
    else if (binary[i] == 'E')
    {
        converted += 14 * (int)Math.Pow(16, counter);
    }
    else if (binary[i] == 'F')
    {
        converted += 15 * (int)Math.Pow(16, counter);
    }


}
Console.WriteLine("Decimal : " + converted);