/* Write a program, which finds the maximal sequence of increasing elements in an array arr[n]. 
 * It is not necessary the elements to be consecutively placed. 
 * E.g.: {9, 6, 2, 7, 4, 7, 6, 5, 8, 4}  {2, 4, 6, 8}.
 */

int[] myArray = { 9, 6, 2, 7, 4, 7, 6, 5, 8, 4 };

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
        if(myArray[j] > temporary[currentIndexer - 1])
        {
            temporary[currentIndexer] = myArray[j];
            currentIndexer++;
            if(currentIndexer > maxSquenceCount)
            {
                maxStartingIndex = i;
                maxSquenceCount = currentIndexer;
            }
        }
    }
}
Console.WriteLine("Starting " + maxStartingIndex + "max count " + maxSquenceCount);