/*  Write a program, which reads an array of integer numbers from
 *  the console and removes a minimal number of elements in such a way
 *  that the remaining array is sorted in an increasing order.
 *  Example: {6, 1, 4, 3, 0, 3, 6, 4, 5}  {1, 3, 3, 4, 5}
*/
int[] myArray = { 6, 1, 4, 3, 0, 3, 6, 4, 5 };

int[] lis = new int[myArray.Length];
int max = 0;
int maxPosition = 0;
for (int i = 0; i < myArray.Length; i++)
{
    lis[i] = 1;
}

for (int i = 1; i < myArray.Length; i++)
{
    for (int j = 0; j < i; j++)
    {
        if (myArray[i] >= myArray[j] && lis[i] < lis[j] + 1)
            lis[i] = lis[j] + 1;
    }
}
for (int i = 0; i < myArray.Length; i++)
{
    if (max < lis[i])
    {
        max = lis[i];
        maxPosition = i;
    }

}
Console.WriteLine("Maximal sequence of increasing elements count is :{0} ", max);

int[] result = new int[max];
int I = (max - 1);
int maxCount = max;
for (int index = maxPosition; index >= 0; index--)
{
    if (lis[index] == max)
    {
        result[I] = myArray[index];
        max--;
        I--;
    }
}

// Print the result[]
Console.WriteLine();
Console.Write("{");
for (int index = 0; index < maxCount; index++)
{
    Console.Write(" " + result[index] + " ");
}
Console.WriteLine("}");
