/*  Write a program, which checks whether there is a subset of given
 *  array of N elements, which has a sum S. The numbers N, S and the array
 *  values are read from the console. Same number can be used many times.
 *  Example: {2, 1, 2, 4, 3, 5, 2, 6}, S = 14  yes (1 + 2 + 5 + 6 = 14)
*/
Console.Write("N :");
int N = int.Parse(Console.ReadLine());

Console.Write("S :");
int S = int.Parse(Console.ReadLine());

int[] myArray = new int[N];
for(int i = 0; i < N; i++)
{
    Console.Write(i + "th element of array : ");
    myArray[i]= int.Parse(Console.ReadLine());
}

bool[,] subset = new bool[S + 1, N + 1];

for (int i = 0; i <= N; i++)
    subset[0, i] = true;

for (int i = 1; i <= S; i++)
    subset[i, 0] = false;

for (int i = 1; i <= S; i++)
{
    for (int j = 1; j <= N; j++)
    {
        subset[i, j] = subset[i, j - 1];
        if (i >= myArray[j - 1])
            subset[i, j] = subset[i, j] || subset[i - myArray[j - 1], j - 1];
    }
}
if (subset[S, N] == true)
    Console.WriteLine("YES");
else
    Console.WriteLine("NO");