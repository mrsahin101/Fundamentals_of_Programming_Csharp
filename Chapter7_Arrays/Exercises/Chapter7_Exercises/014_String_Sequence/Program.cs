/*  Write a program, which finds the longest sequence of equal string
    elements in a matrix. A sequence in a matrix we define as a set of
    neighbor elements on the same row, column or diagonal.
*/

string[,] myArray =
{
    {"ha","fifi","ho","hi" },
    {"fo","ha","hi","xx" },
    {"xxx","ho","ha","xx" }
};
string[,] secondArray = new string[3, 3];
//{
//    {"s","qq","s" },
//    {"pp","qq","s"},
//    {"pp","qq","s" }
//};
secondArray[0, 0] = "s";
secondArray[0, 1] = "pp";
secondArray[0, 2] = "pp";
secondArray[1, 0] = "qq";
secondArray[1, 1] = "qq";
secondArray[1, 2] = "qq";
secondArray[2, 0] = "s";
secondArray[2, 1] = "s";
secondArray[2, 2] = "q";
void FindLongestSequence(string[,] arr, int Iindex, int JIndex)
{
    int maxSequenceCount = 0;
    // direction = 0 -> row, direction = 1 -> col, direction = 2 diagonal;
    int direction = 0;
    int maxSeqIindex = 0;
    int maxSeqJindex = 0;
    string repeatingStr = "";
    for (int i = 0; i < Iindex; i++)
    {
        int rowSeqCount = 0;
        string previous = "";
        for (int j = 0; j < JIndex; j++)
        {
            if (String.Compare(previous, arr[i, j]) == 0)
            {
                rowSeqCount++;
                previous = arr[i, j];
                if (rowSeqCount > maxSequenceCount)
                {
                    maxSequenceCount = rowSeqCount;
                    maxSeqIindex = i;
                    maxSeqJindex = 0;
                    direction = 0;
                    repeatingStr = arr[i, j];
                }
            }
            else
            {
                previous = arr[i, j];
                rowSeqCount = 0;
            }
        }
    }

    for (int j = 0; j < JIndex; j++)
    {
        int colSeqCount = 0;
        string previous = "";
        for (int i = 0; i < JIndex; i++)
        {
            if (String.Compare(previous, arr[i, j]) == 0)
            {
                colSeqCount++;
                previous = arr[i, j];
                if (colSeqCount > maxSequenceCount)
                {
                    maxSequenceCount = colSeqCount;
                    maxSeqIindex = 0;
                    maxSeqJindex = j;
                    direction = 1;
                    repeatingStr = arr[i, j];
                }
            }
            else
            {
                previous = arr[i, j];
                colSeqCount = 0;
            }
        }
    }

    for (int i = 0; i < )
        Console.WriteLine("Maximum Sequence Count is : {0}, Starting Index is [i]: {1}, " +
        " Starting Index is [j]: {2} Repating String is : {3}",
        maxSequenceCount, maxSeqIindex, maxSeqJindex, repeatingStr);
}

FindLongestSequence(secondArray, 3, 3);