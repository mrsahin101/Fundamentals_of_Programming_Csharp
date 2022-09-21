/* Write a program, which finds a subsequence of 
 * numbers with maximal sum. E.g.: {2, 3, -6, -1, 2, -1, 6, 4, -8, 8}  11
 */
int[] myArray = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };
int maxSum = int.MinValue;
int maxSumStartIndex = 0;
int maxSumEndIndex = 0;


for(int i = 0; i < myArray.Length; i++)
{
    int currentSum = 0;
    for (int j = i; j < myArray.Length; j++)
    {
        currentSum += myArray[j];
        if(currentSum > maxSum)
        {
            maxSum = currentSum;
            maxSumStartIndex = i;
            maxSumEndIndex = j;
        }
    }
}
Console.WriteLine("Max sum is :{0} , Starting Index : {1} , Ending Index : {2}" , maxSum,maxSumStartIndex,maxSumEndIndex);
Console.Write("{");
for(int i = maxSumStartIndex; i <=maxSumEndIndex; i++)
{
    Console.Write(myArray[i] + ",");
}
Console.Write("}");


