Console.Write("Number n :");
int n = int.Parse(Console.ReadLine());

Console.Write("Number m :");
int m = int.Parse(Console.ReadLine());

long product = 1;

do
{
    product *= n;
    n++;
}
while (n <= m);
Console.WriteLine("Product = " +  product);