/* Write a program that calculates N!*K!/(N-K)! for given N and K
(1<K<N). 
 */
using System.Numerics;

int n, k;
BigInteger divident = 1;
BigInteger divisor = 1;
BigInteger result = 1;
do
{
    Console.Write("n :");
    n = int.Parse(Console.ReadLine());
    if (n > 1)
        break;
} while (true);

do
{
    Console.Write("k :");
    k = int.Parse(Console.ReadLine());
    if ((k > 1) && (k < n))
        break;
} while (true);


for (int i = k + 1; i <= n; i++)
{
    divisor *=i;
}
for(int i = 1; i <= n; i++)
{
    divident *= i;
}
for (int i = 1; i <= k; i++)
{
    divident *= i;
}

result = divident / divisor;
Console.WriteLine("Result : " + result);
