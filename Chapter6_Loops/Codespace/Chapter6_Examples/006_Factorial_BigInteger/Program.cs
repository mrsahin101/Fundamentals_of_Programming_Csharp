using System.Numerics;

Console.WriteLine("Enter n :");

int n = int.Parse(Console.ReadLine());

BigInteger factorial = 1;

do
{
    factorial *= n;
    n--;
} while (n > 0);
Console.WriteLine(factorial);