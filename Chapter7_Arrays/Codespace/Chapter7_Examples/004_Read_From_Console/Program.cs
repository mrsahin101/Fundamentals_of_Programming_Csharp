Console.Write("How many items you want ? : ");
int n = int.Parse(Console.ReadLine());

int[] myArray = new int[n];
for(int i = 0; i < n; i++)
{
    Console.Write("Please enter " + (i + 1).ToString() + "th number :");
    myArray[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("The list you entered :");
foreach(int i in myArray)
{
    Console.Write(i + ",");
}