/* Write a program, which finds the maximal sequence of consecutive equal elements in an array.
 * E.g.: {1, 1, 2, 3, 2, 2, 2, 1}  {2, 2, 2}.
 */

int[] myarray = { 1, 1, 2, 3, 2, 2, 2, 1 };

int maximumConsecutive = 1;
int maximumConsecutiveItem = 0;
int currentConsecutive = 0;
int previousItem = 0;

for(int i = 0; i < myarray.Length; i++)
{
    if(i == 0)
    {
        previousItem = myarray[i];
        continue;
    }
    if (myarray[i] == previousItem)
    {
        currentConsecutive++;
        if (currentConsecutive > maximumConsecutive)
        {
            maximumConsecutive = currentConsecutive;
            maximumConsecutiveItem = myarray[i];
        }
    }
    else
        currentConsecutive = 0;
    previousItem = myarray[i];
}

if(maximumConsecutive == 1)
    Console.WriteLine("No consecutive item found! Each item is there only 1 time!");
else
{
    Console.Write("{");
    for(int i = 0; i <= maximumConsecutive ; i++)
    {
        Console.Write(maximumConsecutiveItem + ",");
    }
    Console.Write("}");
}
