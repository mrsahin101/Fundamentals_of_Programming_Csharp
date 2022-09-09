/* Question : Write a program that prints on the console the numbers from 1 to N. 
 * The number N should be read from the standard input.*/

Console.Write("n :");
int n = int.Parse(Console.ReadLine());

for(int i = 1; i <= n; i++)
{
    Console.Write(i + ",");
}