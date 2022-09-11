int[] array = { 1, 2, 3, 4, 5, 6, 7, 8 };

Console.WriteLine("Output :");

for(int i = 0; i < array.Length; i++)
{
    array[i] = array[i] * 2;
    Console.WriteLine(array[i]);
}