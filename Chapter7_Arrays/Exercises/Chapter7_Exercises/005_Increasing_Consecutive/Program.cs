/* Write a program, which finds the maximal sequence of consecutively placed increasing integers. 
 * Example: {3, 2, 3, 4, 2, 2, 4}  {2, 3, 4}.
 */

int[] myarray = { 3, 2, 3, 4, 2, 2, 4 };

int maximumConsecutive = 1;
int startingIndex = 0;
int currentConsecutive = 0;
int previousItem = 0;

for (int i = 0; i < myarray.Length; i++)
{
    if (i == 0)
    {
        previousItem = myarray[i];
        continue;
    }
    if (myarray[i] ==  previousItem + 1)
    {
        currentConsecutive++;
        if (currentConsecutive > maximumConsecutive)
        {
            maximumConsecutive = currentConsecutive;
            startingIndex = i - currentConsecutive ;
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
    for (int i = startingIndex; i <= startingIndex + maximumConsecutive; i++)
    {
        Console.Write(myarray[i] + ",");
    }
    Console.Write("}");
}