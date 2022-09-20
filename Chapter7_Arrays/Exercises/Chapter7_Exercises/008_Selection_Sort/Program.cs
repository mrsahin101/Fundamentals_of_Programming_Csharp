/*  Sorting an array means to arrange its elements in an increasing
    (or decreasing) order. Write a program, which sorts an array using the
    algorithm "selection sort".
 */
int[] myArray = { 7, 11, 22, 5, 1, 57, 2, 41 };
Console.WriteLine("Input Array :");
for(int i = 0; i < myArray.Length; i++)
{
    Console.Write(myArray[i] + ",");
}
int swapper = 0;
int tempMinIndex = 0;
for (int i = 0; i < myArray.Length; i++)
{
    tempMinIndex = i;
    for (int j = i + 1; j < myArray.Length; j++)
    {
        if (myArray[j] < myArray[tempMinIndex])
            tempMinIndex= j;
    }
    if (tempMinIndex != i)
    {
        swapper = myArray[i];
        myArray[i] = myArray[tempMinIndex];
        myArray[tempMinIndex] = swapper;
    }
}
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Sorted Array :");
for(int i = 0; i < myArray.Length; i++)
{
    Console.Write(myArray[i] + ",");
}