/*  Write a program which by given N numbers, K and S, finds K elements out
 *  of the N numbers, the sum of which is exactly S or says it is not possible.
 *  Example: {3, 1, 2, 4, 9, 6}, S = 14, K = 3  yes (1 + 2 + 4 = 14)
 */
Console.Write("N :");
int N = int.Parse(Console.ReadLine());

Console.Write("K :");
int K = int.Parse(Console.ReadLine());

Console.Write("S :");
int S = int.Parse(Console.ReadLine());

int[] rawArray = new int[N];
for(int i = 0; i < N; i++)
{
    Console.Write(i + "th element :");
    rawArray[i] = int.Parse(Console.ReadLine());
}
int swapper = 0;
int tempMinIndex = 0;

for (int i = 0; i < rawArray.Length; i++)
{
    tempMinIndex = i;
    for (int j = i + 1; j < rawArray.Length; j++)
    {
        if (rawArray[j] < rawArray[tempMinIndex])
            tempMinIndex= j;
    }
    if (tempMinIndex != i)
    {
        swapper = rawArray[i];
        rawArray[i] = rawArray[tempMinIndex];
        rawArray[tempMinIndex] = swapper;
    }
}
int subArrayCount = 0;
for(int i = 0; i < rawArray.Length; i++)
{
    if (rawArray[i] < S)
        subArrayCount++;
    else
        break;
}

int[] myArray = new int[subArrayCount];
bool matchFound = false;
if()
for(int i = 0; i < myArray.Length; i++)
{
   if(myArray[i] < S)

}