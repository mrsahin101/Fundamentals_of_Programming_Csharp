/*  Write a program, which reads from the console two integer numbers 
 *  N and K (K<N) and array of N integers.
 *  Find those K consecutive elements in the array, which have maximal sum.
 */

Console.Write("N:");
int n = int.Parse(Console.ReadLine());

Console.Write("K:");
int k = int.Parse(Console.ReadLine());

int[] myArray = new int[n];

for (int i = 0; i < n; i++)
{
    Console.Write((i + 1) + "th element of array :");
    myArray[i] = int.Parse(Console.ReadLine());
}
int maxSum = 0;
int maxSumIndex = 0;

for(int i = 0; i < n - k + 1; i++)
{
    int sum = 0;
    for(int j = i; j < k + i; j++)
    {
        sum += myArray[j];
    }
    if(sum > maxSum)
    {
        maxSum = sum;
        maxSumIndex = i;
    }
}
Console.WriteLine("Maximum sum Index is : {0} and Maximum sum is : {1}", maxSumIndex, maxSum);
Console.Write("{");
for(int i = maxSumIndex; i < k + maxSumIndex; i++)
{
    Console.Write(myArray[i] + ",");
}
Console.Write("}");