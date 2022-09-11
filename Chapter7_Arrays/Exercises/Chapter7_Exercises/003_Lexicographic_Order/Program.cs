/* Write a program, which compares two arrays of type char lexicographically (character by character) and checks,
 * which one is first in the lexicographical order.
 */

char[] firstArray = { 'i', 'w', 'i', 'l', 'l', 'm', 'a', 's', 't', 'e', 'r' };
char[] secondArray = { 'C', 'S', 'h', 'a', 'r', 'p' };

int index = 0;

if(firstArray.Length <= secondArray.Length)
    index = firstArray.Length;
else 
    index = secondArray.Length;

bool firstSmaller = false;
bool secondSmaller = false;

for (int i = 0; i < index; i++)
{
    if(firstArray[i] < secondArray[i])
    {
        firstSmaller = true;
        break;
    }
    if(secondArray[i] < firstArray[i])
    {
        secondSmaller = true;
        break;
    }
}
if (firstSmaller == false && secondSmaller == false)
{
    if (secondArray.Length == firstArray.Length)
        Console.WriteLine("They are Equal!");
    else if (secondArray.Length < firstArray.Length)
        Console.WriteLine("Second Array is comes earlier!");
    else if (firstArray.Length < secondArray.Length)
        Console.WriteLine("First Array is comes earlier!");
}
else if(firstSmaller == true)
    Console.WriteLine("First Array is comes earlier!");
else if(secondSmaller == true)
    Console.WriteLine("Second Array is comes earlier!");