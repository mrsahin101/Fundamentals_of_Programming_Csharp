static void printTime(int hours,int minutes)
{
    if (hours < 0 || hours > 23)
        throw new ArgumentOutOfRangeException("Not valid Hours!");
    if (minutes < 0 || minutes > 59)
        throw new ArgumentOutOfRangeException("Not valid minutes");
    
    Console.WriteLine("The time is {0:00}:{1:00}",hours,minutes);
}
Console.Write("Hours :");
int hours = int.Parse(Console.ReadLine());

Console.Write("Minutes :");
int minutes = int.Parse(Console.ReadLine());
printTime(hours,minutes);   