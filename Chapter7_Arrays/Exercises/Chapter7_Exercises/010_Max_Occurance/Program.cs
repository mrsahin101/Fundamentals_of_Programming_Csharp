/*  Write a program, which finds the most frequently occurring element in
    an array. Example: {4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3} -> 4 (5 times).
*/
int[] myArray = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };

Dictionary<int, int> myDict = new Dictionary<int, int>();

for (int i = 0; i < myArray.Length; i++)
{
    if (myDict.ContainsKey(myArray[i]))
    {
        myDict[myArray[i]] = myDict[myArray[i]] + 1;
    }
    else
    {
        myDict.Add(myArray[i], 1);
    }
}
foreach(int key in myDict.Keys)
{
    Console.WriteLine(key + "," + myDict[key] + " times;");
}
int element = 0;
int count = 0;

foreach(int key in myDict.Keys)
{
    if(myDict[key] > count)
    {
        element = key;
        count = myDict[key];
    }
}

Console.WriteLine("The most occuring element is {0} and its appearing {1} times!", element, count);