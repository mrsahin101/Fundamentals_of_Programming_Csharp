/*  Write a program, which creates a rectangular array with size of n by m
    elements. The dimensions and the elements should be read from the
    console. Find a platform with size of (3, 3) with a maximal sum.
*/
Console.Write("n :");
int n = int.Parse(Console.ReadLine());

Console.Write("m : ");
int m = int.Parse(Console.ReadLine());

int[,] myArray = new int[n, m];
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write("Enter value of [{0},{1}] : ", i, j);
        myArray[i, j] = int.Parse(Console.ReadLine());
    }
}
int maxSum = 0;
int maxSumIindex = 0;
int maxSumJindex = 0;
for (int i = 0; i <= n - 3; i++)
{
    for (int j = 0; j <= m - 3; j++)
    {
        int sum = 0;
        sum += myArray[i, j] + myArray[i, j + 1] + myArray[i, j + 2];
        sum += myArray[i + 1, j] + myArray[i + 1, j + 1] + myArray[i + 1, j + 2];
        sum += myArray[i + 2, j] + myArray[i + 2, j + 1] + myArray[i + 2, j + 2];

        if (sum > maxSum)
        {
            maxSum = sum;
            maxSumIindex = i;
            maxSumJindex = j;
        }
    }
}
Console.WriteLine("Maximum sum is : {0} and Starting index is i : {1}, j : {2}", maxSum, maxSumIindex, maxSumJindex);

Console.WriteLine();

for (int i = maxSumIindex; i < maxSumIindex + 3; i++)
{
    for (int j = maxSumJindex; j < maxSumJindex + 3; j++)
    {
        Console.Write(myArray[i, j] + "  ");
    }
    Console.WriteLine();
}