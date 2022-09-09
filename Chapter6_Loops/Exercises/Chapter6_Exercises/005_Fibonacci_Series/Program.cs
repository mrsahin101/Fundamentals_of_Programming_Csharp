/* Write a program that reads from the console number N and print the sum
of the first N members of the Fibonacci sequence: 0, 1, 1, 2, 3, 5, 8,
13, 21, 34, 55, 89, 144, 233, 377, …
*/
using System.Numerics;


Console.Write("n :");
int n = int.Parse(Console.ReadLine());

BigInteger sum = 2;
int current = 1;
int previous = 1;
int temporary = 0;
while(true)
{
    temporary = current;
    current = current + previous;
    previous = temporary;
    if (!(current < n))
        break;
    else
        sum += current;
    
}
Console.WriteLine("Sum : " + sum);
