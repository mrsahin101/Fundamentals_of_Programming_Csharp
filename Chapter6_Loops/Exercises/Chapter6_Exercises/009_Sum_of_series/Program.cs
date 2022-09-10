/* Write a program that for a given integers n and x, calculates the sum:
 * S = 1 + 1!/x + 2!/x^2 + 3!/x^3 + ... + n!/x^n
 */
Console.Write("n :");
int n = int.Parse(Console.ReadLine());

Console.Write("x :");
int x = int.Parse(Console.ReadLine());

double sum = 1;

for(int i = 1; i <= n; i++)
{
    double elementResult = 1;
    for(int j = 1; j <= i; j++)
    {
        elementResult *= j;
    }
    elementResult = elementResult / (Math.Pow(x, i));
    sum += elementResult;
}
Console.WriteLine("Result : " + sum);