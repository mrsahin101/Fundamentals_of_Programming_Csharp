/* In combinatorics, the Catalan numbers are calculated by the following
formula:  Cn = (1/n+1) * (2n over n) = (2n!)/((n + 1)!n!)
for n ≥ 0. Write a program that
calculates the nth Catalan number by given n.
*/
using System.Numerics;
BigInteger catalanNumber;
BigInteger divident = 1;
BigInteger divisor = 1;
Console.Write("n :");
int n = int.Parse(Console.ReadLine());

for(int i = n + 1; i <= 2 * n; i++)
{
    divident *= i;
}

for (int i = 1; i <= n + 1; i++)
{
    divisor *= i;
}
catalanNumber = divident / divisor;

Console.WriteLine("Catalan Number : " + catalanNumber);
