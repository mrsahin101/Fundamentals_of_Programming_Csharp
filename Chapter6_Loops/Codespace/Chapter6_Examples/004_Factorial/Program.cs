Console.Write("Please enter number i :");
int i = int.Parse(Console.ReadLine());

decimal factorial = 1;

while(true)
{
    if(i <= 1)
    {
        break;
    }
    factorial *= i;
    i--;
}
Console.WriteLine("Result of factorial is : " + factorial);