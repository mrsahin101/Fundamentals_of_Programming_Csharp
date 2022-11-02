static double GetRectangleArea(double width, double height)
{
    double area = width * height;
    return area;
}
Console.WriteLine(GetRectangleArea(3.0, 2));

static void PrintLogo()
{
    Console.WriteLine("Microsoft");
    Console.WriteLine("www.microsoft.com");
}
PrintLogo();

static void PrintTotalAmountForBooks(decimal[] prices)
{
    decimal totalAmount = 0;
    foreach(decimal singleBookPrince in prices)
    {
        totalAmount += singleBookPrince;
    }
    Console.WriteLine("The total amount for all books is : " + totalAmount);
}
decimal[] myPrices = { 3, 2, 3.1m };
PrintTotalAmountForBooks(myPrices);

static void PrintSign(int number)
{
    if(number > 0)
    {
        Console.WriteLine("Positive");
    }
    else if (number < 0)
    {
        Console.WriteLine("Negative");
    }
    else
    {
        Console.WriteLine("Zero");
    }
}
PrintSign(5);

static void PrintMax(float number1, float number2)
{
    float max = number1;
    if(number2 > max)
    {
        max = number2;
    }
    Console.WriteLine("Maximal Number : " + max);
}
PrintMax(3.2f, 3.0f);