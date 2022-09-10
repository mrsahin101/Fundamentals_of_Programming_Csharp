/*  Write a program that calculates with how many zeroes the factorial of
    a given number ends. Examples:
    N = 10 -> N! = 3628800 -> 2
    N = 20 -> N! = 2432902008176640000 -> 4
*/
using System.Numerics;

BigInteger factorial = 1;

Console.Write("n :");
int n = int.Parse(Console.ReadLine());

for(int i = 1; i <= n; i++)
{
    factorial *=i;
}
int zeroCount = 0;
while(true)
{
    if (factorial % 10 == 0)
    {
        factorial /= 10;
        zeroCount++;
    }
    else
        break;
}
Console.WriteLine("Zeros Count : " + zeroCount);
