static int[] Sort(params int[] numbers)
{
    // Selection Sort example!
    for(int i = 0; i < numbers.Length - 1; i++)
    {
        for(int j = i + 1;  j < numbers.Length; j++)
        {
            if(numbers[i] > numbers[j])
            {
                int temporary = numbers[i];
                numbers[i] = numbers[j];
                numbers[j] = temporary;
            }
        }
    }
    return numbers;
}
static void PrintNumbers(params int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + ",");
    }
}
PrintNumbers(Sort(10, 3, 5, -1, 0, 12, 8));