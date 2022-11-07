
static void calculateDifference(int firstMonthIndex, int secondMonthIndex)
{
    string[] months = new string[] { "January", "February", "March", "April", "May", "June",
    "July", "August", "September", "October", "November", "December" };
    int difference = secondMonthIndex - firstMonthIndex;
    if (difference < 0)
        difference = difference + 12;
    Console.WriteLine("There is {0} months period from {1} to {2}",difference, months[firstMonthIndex],
        months[secondMonthIndex]);
}

Console.Write("First Month (1-12) : ");
int firstMonth = int.Parse(Console.ReadLine());

Console.Write("Second Month (1-12) : ");
int secondMonth = int.Parse(Console.ReadLine());

calculateDifference(firstMonth, secondMonth);