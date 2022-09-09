/* Write a program that prints on the console the numbers from 1 to N, 
 * which are not divisible by 3 and 7 simultaneously. 
 * The number N should be read from the standard input.*/

Console.Write("n :");
int n = int.Parse(Console.ReadLine());

for(int i = 1; i <= n; i++)
{
    if (!(i % 3 == 0 && i % 7 == 0))
        Console.Write(i + ",");
}
