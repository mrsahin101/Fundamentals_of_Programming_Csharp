Console.Write("How many items you want ? : ");
int n = int.Parse(Console.ReadLine());

int[] myArray = new int[n];
for (int i = 0; i < n; i++)
{
    Console.Write("Please enter " + (i + 1).ToString() + "th number :");
    myArray[i] = int.Parse(Console.ReadLine());
}

bool checkSymmetric()
{
    for(int i = 0, indexer = n -1 ; i < n;i++,indexer--)
    {
        if(myArray[i] != myArray[indexer])
            return false;
    }
    return true;
}

if (checkSymmetric())
    Console.WriteLine("It's Symmetric!");
else
    Console.WriteLine("It's not Symmetric!");