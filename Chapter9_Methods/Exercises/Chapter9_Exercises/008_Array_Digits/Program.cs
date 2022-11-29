using System.Numerics;

static int[] StoreInArrayDigits(BigInteger inputInt)
{
    int[] arrayDigits = new int[10001];
    // initialize
    for (int i = 0; i < arrayDigits.Length; i++)
        arrayDigits[i] = 0;
    int indexTracker = 0;
    while(inputInt > 0)
    {
        arrayDigits[indexTracker] = (int)(inputInt % 10);
        inputInt /= 10;
        indexTracker++;
    }
    return arrayDigits;
}
static int[] CalculateInArrayDigits(int[] firstOperand, int[] secondOperand)
{
    int[] calculatedResult = new int[10001];
    for(int i = 0; i < 10001; i++)
    {
        if (firstOperand[i] + secondOperand[i] > 9)
            calculatedResult[i + 1] += 1;
        calculatedResult[i] = firstOperand[i] + secondOperand[i];
    }
    return calculatedResult;
}
static void PrintResult(int[] digitsArray)
{
    bool matchFound = false;
    for (int i = 10000; i >= 0; i--)
    {
        if (digitsArray[i] != 0)
            matchFound = true;
        if(matchFound)
            Console.Write(digitsArray[i]);
    } 
}

BigInteger firstNumber = 1111111111111111114;
BigInteger secondNumber = 2222222222222222224;

PrintResult(CalculateInArrayDigits(StoreInArrayDigits(firstNumber), StoreInArrayDigits(secondNumber)));