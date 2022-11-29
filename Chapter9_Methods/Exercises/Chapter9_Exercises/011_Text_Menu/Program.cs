static int reversedOrder(int number)
{
    int reversedNumber = 0;
    while(number > 0)
    {
        int digit = number % 10;
        reversedNumber *= 10;
        reversedNumber += digit;
        number /= 10;
    }
    return reversedNumber;
}
static int calculateAverage(params int[] sequence)
{
    int sum = 0;
    for(int i = 0; i < sequence.Length; i++)
    {
        sum += sequence[i];
    }
    return sum / sequence.Length;
}
static double solveLinearEq(int a, int b)
{
    // to solve a * x + b = 0; equation a and b must be known
    // a * x = - b;
    // x = - b / a; -> x = (b / a) * (- 1); can write this
    return ((double)b / a) *(-1);
}
static void firstCaseHandler()
{
    Console.WriteLine("You have choosen reversing digits of number operation!");
    Console.Write("Please enter the number you want to reverse :");
    int number = int.Parse(Console.ReadLine());
    if (number < 1 || number > 50000000)
        throw new Exception("Your input must be between 1 and 50.000.000");
    Console.WriteLine("Your number (" + number + ") is reversed. Result is :" + reversedOrder(number));
}
static void printFreeSpace(int count)
{
    for(int i = 0; i < count; i++)
    {
        Console.WriteLine();
    }
}
static void secondCaseHandler()
{
    Console.WriteLine("You have choosen calculating average of sequence!");
    Console.Write("Please enter how many element your sequence has : ");
    int count = int.Parse(Console.ReadLine());
    Console.WriteLine("Please start entering your all "+ count + " items!");
    if (count == 0)
        throw new Exception("Sequence cannot be 0 items!");
    int[] mySequence = new int[count];
    for (int i = 0; i < count; i++)
    {
        Console.Write("Please enter " + (i + 1) + "th element of sequence : ");
        mySequence[i] = int.Parse(Console.ReadLine());
    }
    printFreeSpace(2);
    Console.WriteLine("Your sequence is :");
    Console.Write("{");
    for (int i = 0; i < count; i++)
    {
        Console.Write(mySequence[i]);
        if(i + 1 < count)
            Console.Write(",");
    }
    Console.Write("}");
    printFreeSpace(2);
    Console.WriteLine("Average of your sequence is : " + calculateAverage(mySequence));
}
static void thirdCaseHandler()
{
    printFreeSpace(2);
    Console.WriteLine("You have choosen solving linear equation!");
    Console.Write("Please enter a :");
    int a = int.Parse(Console.ReadLine());
    if (a == 0)
        throw new Exception("a cannot be zero!");
    Console.Write("Please enter b :");
    int b = int.Parse(Console.ReadLine());
    printFreeSpace(2);
    Console.Write("Solution of equation (");
    if(a != 1)
        Console.Write(a);
    Console.Write("x + " + b + " = 0) is :");
    printFreeSpace(1);
    Console.WriteLine("x :" + solveLinearEq(a, b));
}

int menuSelector = 0;
Console.WriteLine("Please Choose which operation you want to perform!");
Console.WriteLine("[1]Reverse digits of the number!");
Console.WriteLine("[2]Calculate average of given sequence!");
Console.WriteLine("[3]Solve Linear Equation in form (a * x + b = 0)");

printFreeSpace(2);

Console.Write("Your Choice ?[1..3] : ");
menuSelector = int.Parse(Console.ReadLine());
// assuming user co-operating well. int.parse always return good stuff
printFreeSpace(2);

switch (menuSelector)
{
    case 1:
        firstCaseHandler();
        break;
    case 2:
        secondCaseHandler();
        break;
    case 3:
        thirdCaseHandler();
        break;
    default:
        Console.WriteLine("Unknown entry!");
        break;
}
