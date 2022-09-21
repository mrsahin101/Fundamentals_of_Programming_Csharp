/* Write a program, which sorts an array of integer elements using a "merge
sort" algorithm.
*/

int[] arr = { 12, 11, 13, 5, 6, 7 };
static void merge(int[] arr, int l, int m, int r)
{
    int n1 = m - l + 1;
    int n2 = r - m;

    int[] L = new int[n1];
    int[] R = new int[n2];
    int i, j;

    for (i = 0; i < n1; ++i)
        L[i] = arr[l + i];
    for (j = 0; j < n2; ++j)
        R[j] = arr[m + 1 + j];

    i = 0;
    j = 0;

    int k = l;
    while (i < n1 && j < n2)
    {
        if (L[i] <= R[j])
        {
            arr[k] = L[i];
            i++;
        }
        else
        {
            arr[k] = R[j];
            j++;
        }
        k++;
    }

    while (i < n1)
    {
        arr[k] = L[i];
        i++;
        k++;
    }

    while (j < n2)
    {
        arr[k] = R[j];
        j++;
        k++;
    }
}
static void sort(int[] array, int l, int r)
{
    if (l < r)
    {
        int m = l + (r - l) / 2;

        sort(array, l, m);
        sort(array, m + 1, r);

        merge(array, l, m, r);
    }
}

Console.WriteLine("Given Array (unsorted) is : ");
Console.Write("{");
for (int i = 0; i < arr.Length; i++)
{
    Console.Write(arr[i] + ",");
}
Console.Write("}");
sort(arr, 0, arr.Length - 1);

Console.WriteLine();
Console.WriteLine();

Console.WriteLine("Sorted Array is : ");

Console.Write("{");
for (int i = 0; i < arr.Length; i++)
{
    Console.Write(arr[i] + ",");
}
Console.Write("}");