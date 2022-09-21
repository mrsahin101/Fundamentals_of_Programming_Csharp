// Declare the variables
int startingIndex = 1;
int endingIndex = 10000;
bool flag = false;
int i = 0, j = 0;
Console.WriteLine("Prime numbers between {0} and {1} are :");


for (i = startingIndex; i <= endingIndex; i++)
{

    if (i == 1 || i == 0)
        continue;

    flag = true;

    for (j = 2; j <= i / 2; ++j)
    {
        if (i % j == 0)
        {
            flag = false;
            break;
        }
    }

    // flag = 1 means i is prime
    // and flag = 0 means i is not prime
    if (flag == true)
        Console.WriteLine("{0}", i);
}
