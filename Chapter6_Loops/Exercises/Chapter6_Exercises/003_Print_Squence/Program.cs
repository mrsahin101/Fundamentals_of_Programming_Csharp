/* Write a program that reads from the console a series of integers 
 * and prints the smallest and largest of them.*/

bool anotherOne = false;
int[] myNumbers = new int[20];
int counter = 0;
do
{
    anotherOne = false;
    Console.Write("new number : ");
    int newNumber = int.Parse(Console.ReadLine());
    myNumbers[counter] = newNumber;

    Console.WriteLine();

    do
    {
        Console.Write("Do you want to add another number?(Y/N) : ");
        string answer = Console.ReadLine();
        if (answer.ToUpper() == "Y")
        {
            anotherOne = true;
            break;

        }
        else if(answer.ToUpper() == "N")
        {
            anotherOne = false;
            break;
        }
    } while (true);
    counter++;

} while (anotherOne);
int swapper = 0;

for (int i = 0; i < counter; i++)
{
    for(int j = i + 1; j < counter; j++)
    {
        if(myNumbers[i] > myNumbers[j])
        {
            swapper = myNumbers[i];
            myNumbers[i] = myNumbers[j];
            myNumbers[j] = swapper;
        }
        
    }
}

Console.WriteLine("Smallest : " + myNumbers[0] + ", Biggest : " + myNumbers[counter - 1]);