/* Write a program that by a given integer N prints the numbers from 1 to N
in random order.
*/

Random rnd = new Random();

Console.Write("n : ");
int n = int.Parse(Console.ReadLine());

List<int> numberlist = new List<int>();   
for(int i = 1; i <= n; i++)
{
    numberlist.Add(i);
}
int index;
for(int i = n - 1; i >= 0; i--)
{
    if (i > 0)
        index = rnd.Next(0, i);
    else
        index = 0;
    Console.Write(numberlist.ElementAt(index) + ",");
    numberlist.RemoveAt(index);
    
}