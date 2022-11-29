static int[] SortDescending(params int[] numbers)
{
    // Selection Sort example!
    for (int i = 0; i < numbers.Length - 1; i++)
    {
        for (int j = i + 1; j < numbers.Length; j++)
        {
            if (numbers[i] < numbers[j])
            {
                int temporary = numbers[i];
                numbers[i] = numbers[j];
                numbers[j] = temporary;
            }
        }
    }
    return numbers;
}
Console.WriteLine("Biggest element in my array is : " + ((SortDescending(1, 5, 7, 2, 3, 11, 4, 9))[0]));