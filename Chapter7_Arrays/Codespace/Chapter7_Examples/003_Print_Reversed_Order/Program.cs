int[] myarray = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

Console.WriteLine("Straight Order :");
for(int i = 0; i <myarray.Length; i++)
{
    Console.Write(myarray[i] + ",");
}
Console.WriteLine();
Console.WriteLine("Reversed Order :");
for (int i = myarray.Length -1 ; i >=0; i--)
{
    Console.Write(myarray[i] + ",");
}