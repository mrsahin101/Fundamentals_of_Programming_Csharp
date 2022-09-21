/* Write a program, which finds the maximal sequence of increasing elements in an array arr[n]. 
 * It is not necessary the elements to be consecutively placed. 
 * E.g.: {9, 6, 2, 7, 4, 7, 6, 5, 8, 4}  {2, 4, 6, 8}.
 */
int[] myArray = { 9, 6, 2, 7, 4, 7, 6, 5, 8, 4 };

int[] lis = new int[myArray.Length];
int max = 0;
int maxPosition = 0;
for(int i = 0; i < myArray.Length; i++)
{
    lis[i] = 1;
}

for(int i = 1; i < myArray.Length; i++)
{
    for(int j = 0; j < i; j++)
    {
        if(myArray[i] > myArray[j] && lis[i] < lis[j] + 1)
            lis[i] = lis[j] + 1;
    }
}
for(int i = 0; i < myArray.Length; i++)
{
    if(max < lis[i])
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
















/***** FAILED SOLUTION *****/
/*
int[] myArray = { 9, 6, 2, 7,4,7, 6, 5, 8, 4 };

int maxSquenceCount = 1;
int maxStartingIndex = 0;
int currentIndexer = 0;

for(int i = 0; i < myArray.Length; i++)
{
    int[] temporary = new int[myArray.Length];
    currentIndexer = 1;
    temporary[0] = myArray[i];
    for(int j = i + 1; j < myArray.Length; j++)
    {
        //for(int k =  )
        if(myArray[j] > temporary[currentIndexer - 1])
        {
            temporary[currentIndexer] = myArray[j];
            currentIndexer++;
            if (currentIndexer > maxSquenceCount)
            {
                maxStartingIndex = i;
                maxSquenceCount = currentIndexer;
            }
        }
    }
}
Console.WriteLine("Starting " + maxStartingIndex + "max count " + maxSquenceCount);
*/