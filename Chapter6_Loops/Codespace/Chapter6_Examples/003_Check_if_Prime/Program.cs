// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter n :");

int n = int.Parse(Console.ReadLine());

bool divisonFound = false;

int divisor = n /2;

while(divisor >= 2)
{
    if(n % divisor == 0)
    {
        divisonFound = true;
        break;
    }
    divisor--;
}
if (divisonFound)
    Console.WriteLine("It's not prime");
else
    Console.WriteLine("It's prime");
