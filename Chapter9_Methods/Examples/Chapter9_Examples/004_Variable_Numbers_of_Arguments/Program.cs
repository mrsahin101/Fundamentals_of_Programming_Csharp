static void PrintTotalAmountForBooks(decimal[] Prices)
{
    decimal totalAmount = 0;
    foreach(decimal singleBookPrice in Prices)
    {
        totalAmount +=singleBookPrice;
    }
    Console.WriteLine("The total amount of all books is :" + totalAmount);
}
decimal[] prices = new decimal[] { 3m, 2.5m };
PrintTotalAmountForBooks(prices);

// Or this is possible as well
decimal[] secondprices = new decimal[] { 3m, 1.5m, 3m, 0.2m };
PrintTotalAmountForBooks(secondprices);


static long CalcSum(params int[] elements)
{
    long sum = 0;
    foreach(int element in elements)
    {
        sum += element;
    }
    return sum;
}
long sum = CalcSum(2, 5);
Console.WriteLine(sum);

long sum2 = CalcSum(4, 0, -2, 15);
Console.WriteLine(sum2);

long sum3 = CalcSum();
Console.WriteLine(sum3);

// working with params and arrays almost same for variable numbers of arguments!

static void VariablePrintTotalAmountForBooks(params decimal[] Prices)
{
    decimal totalAmount = 0;
    foreach (decimal singleBookPrice in Prices)
    {
        totalAmount +=singleBookPrice;
    }
    Console.WriteLine("The total amount of all books is :" + totalAmount);
}
VariablePrintTotalAmountForBooks(2m, 3m, 1m);
VariablePrintTotalAmountForBooks(2m, 35m, 1m,3.5m,1.2m);