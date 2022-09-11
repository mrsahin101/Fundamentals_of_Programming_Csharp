/* Write a program that given two numbers finds their greatest common
    divisor (GCD) and their least common multiple (LCM). You may use
    the formula LCM(a, b) = |a*b| / GCD(a, b).
 */

/* Can implement GCD with  Euclidean algorithm
 * https://en.wikipedia.org/wiki/Euclidean_algorithm
 */

Console.Write("a :");
int a = int.Parse(Console.ReadLine());

Console.Write("b :");
int b = int.Parse(Console.ReadLine());

Console.WriteLine("GCD : " + getGCD(a,b));

Console.WriteLine("LCM : " + (Math.Abs(a*b) / getGCD(a,b)));

int getGCD(int a,int b)
{
    if (b == 0)
        return a;
    else
        return getGCD(b, a % b);
}


