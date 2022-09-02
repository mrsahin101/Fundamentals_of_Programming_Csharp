
Console.WriteLine("Please enter n :");

int n = int.Parse(Console.ReadLine());

int myNumber = 1;
int sum = 0;
while(myNumber <= n)
{
    sum += myNumber;
    Console.WriteLine("My Number :" + myNumber + "  Sum : " + sum);
    myNumber++;
}
