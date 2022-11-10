static int DecimalReverser(int number)
{
    int reversed = 0;
    while(number > 0)
    {
        reversed *= 10;
        reversed += number % 10;
        number = number / 10;
    }
    return reversed;
}
Console.WriteLine(DecimalReverser(256));