static int Add(int number1, int number2)
{
    int result = number1 + number2;
    return result;
    result = 0;
}
static int CompareTo(int number1, int number2)
{
    if (number1 > number2)
        return 1;
    else if (number1 == number2)
        return 0;
    else 
        return -1;
}
Console.WriteLine(CompareTo(1, 2));