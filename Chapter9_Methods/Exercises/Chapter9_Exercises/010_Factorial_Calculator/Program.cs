using System.Numerics;

static void PrintFactorial(int n)
{
    if (n == 0 || n > 100)
        throw new ArgumentException("invalid parameter!");
    else
    {
        BigInteger factorial = 1;
        for(int i = 1; i < n; i++)
        {
            factorial *= i;
        }
        Console.WriteLine("Factorial of " +  n + " is : " + factorial.ToString());
    }
}
Console.Write("Enter the number you want to calculate its factorial [1-100] :");
int number = int.Parse(Console.ReadLine());
PrintFactorial(number);