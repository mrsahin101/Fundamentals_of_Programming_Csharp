static int GetMax(int firstNumber, int secondNumber)
{
    if (firstNumber > secondNumber)
        return firstNumber;
    else
        return secondNumber;
}
Console.Write("First Number : ");
int firstNumber = int.Parse(Console.ReadLine());

Console.Write("Second Number :");
int secondNumber = int.Parse(Console.ReadLine());

Console.Write("Third Number :");
int thirdNumber = int.Parse(Console.ReadLine());

Console.WriteLine("Maximum number is :" + GetMax(firstNumber,GetMax(secondNumber,thirdNumber)));