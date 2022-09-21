﻿/*  Write a program, which sorts an array of integer elements using a "quick
    sort" algorithm
*/
// A utility function to swap two elements
static void swap(int[] arr, int i, int j)
{
    int temp = arr[i];
    arr[i] = arr[j];
    arr[j] = temp;
}
static void quickSort(int[] arr, int low, int high)
{
    if (low < high)
    {
        int pi = partition(arr, low, high);
        quickSort(arr, low, pi - 1);
        quickSort(arr, pi + 1, high);
    }
}
static int partition(int[] arr, int low, int high)
{
    int pivot = arr[high];
    int i = (low - 1);
    for (int j = low; j <= high - 1; j++)
    {
        if (arr[j] < pivot)
        {
            i++;
            swap(arr, i, j);
        }
    }
    swap(arr, i + 1, high);
    return (i + 1);
}

int[] arr = { 10, 7, 8, 9, 1, 5 };
int n = arr.Length;

Console.WriteLine("UnSorted array: ");
Console.Write("{");
for (int i = 0; i < arr.Length; i++)
{
    Console.Write(arr[i] + ",");
}
Console.Write("}");
Console.WriteLine();
Console.WriteLine();
quickSort(arr, 0, n - 1);

Console.WriteLine("Sorted array: ");
Console.Write("{");
for (int i = 0; i < arr.Length; i++)
{
    Console.Write(arr[i] + ",");
}
Console.Write("}");