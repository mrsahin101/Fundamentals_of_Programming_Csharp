/* Write a program, which finds the maximal sequence of consecutively placed increasing integers. 
 * Example: {3, 2, 3, 4, 2, 2, 4}  {2, 3, 4}.
 */

int[] myarray = { 3, 2, 3, 4, 2, 2, 4 };

int maximumConsecutive = 1;
int startingIndex
int currentConsecutive = 0;
int previousItem = 0;

for (int i = 0; i < myarray.Length; i++)
{
    if (i == 0)
    {
        previousItem = myarray[i];
        continue;
    }
    if (myarray[i] > previousItem)
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

if (maximumConsecutive == 1)
    Console.WriteLine("No consecutive item found! Each item is there only 1 time!");
else
{
    Console.Write("{");
    for (int i = 0; i <= maximumConsecutive; i++)
    {
        Console.Write(maximumConsecutiveItem + ",");
    }
    Console.Write("}");
}