Console.Write("Enter how many item first array has :");
int firstCount = int.Parse(Console.ReadLine());

Console.Write("Enter how many item second array has :");

int secondCount = int.Parse(Console.ReadLine());

if (firstCount != secondCount)
{
    Console.WriteLine("This arrays are not equal!");
    goto end;
}

int[] firstArray = new int[firstCount];
int[] secondArray = new int[secondCount];

for(int i = 0; i < firstCount; i++)
{
    Console.Write("Enter " + (i + 1) + "th element of first array :");
    firstArray[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine();
Console.WriteLine("First Array entering done. Please enter second Array!");
Console.WriteLine();

for (int i = 0; i < secondCount; i++)
{
    Console.Write("Enter " + (i + 1) + "th element of first array :");
    secondArray[i] = int.Parse(Console.ReadLine());
}

for(int i = 0; i < firstCount; i++)
{
    if(firstArray[i] != secondArray[i])
    {
        Console.WriteLine("This arrays not equal!");
        goto end;
    }
}

Console.WriteLine("This arrays are EQUAL!");


end:
    Console.WriteLine();