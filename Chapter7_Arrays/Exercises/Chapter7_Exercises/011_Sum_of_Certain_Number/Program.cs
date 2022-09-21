/* Write a program to find a sequence of neighbor numbers in an array,
 * which has a sum of certain number S. Example: {4, 3, 1, 4, 2, 5, 8},
 * S=11  {4, 2, 5}.
 */

int[] myArray = { 4, 3, 1, 4, 2, 5, 8 };

Console.Write("S :");
int S = int.Parse(Console.ReadLine());

bool matchFound = false;
int startingIndex = 0;
int endingIndex = 0;

for(int i = 0; i < myArray.Length; i++)
{
    int currentSum = 0;
    for(int j = i; j < myArray.Length; j++)
    {
        currentSum += myArray[j];
        if (currentSum == S)
        {
            matchFound = true;
            startingIndex = i;
            endingIndex = j;
            goto result;
        }
        else if (currentSum > S)
            break;
    }
}
result:
if (matchFound)
{
    Console.WriteLine("Match Found!");
    Console.Write("{");
    for(int i = startingIndex; i <= endingIndex; i++)
    {
        Console.Write(myArray[i] + ",");
    }
    Console.Write("}");
    Console.WriteLine();
    Console.WriteLine("Sum is (S) = {0}",S);
}
else
    Console.WriteLine("Couldn't find any match!");