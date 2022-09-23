/* Write a program, which creates square matrices like those in the 
 * figures below and prints them formatted to the console. The size of the matrices will be read from the console.
 * See the examples for matrices with size of 4 x 4 and make the other sizes in a similar fashion:
 *
 * 7  11 14 16
 * 4  8  12 15  
 * 2  5  9  13
 * 1  3  6  10
 * 
 */

Console.Write("Row count : ");
int row = int.Parse(Console.ReadLine());

Console.Write("Col count : ");
int col = int.Parse(Console.ReadLine());

int number = 1;
int maxNumber = row * col;

int cursorX = 0;
int cursorY = row - 1;
int rowIndexer = row - 1;
int colIndexer = 0;
int rowTracker = row - 1;
int colTracker = 0;

Console.SetCursorPosition(cursorX, cursorY);
Console.Clear();
while (number <= maxNumber)
{

    for (int j = colIndexer; j <= colTracker; j++)
    {
        Console.SetCursorPosition(cursorX, cursorY);
        Console.Write(number);
        number++;
        cursorY++;
        cursorX += 3;
    }
    if (rowIndexer == 0)
        rowTracker--;
    if (rowIndexer > 0)
        rowIndexer--;
    if (colTracker == col -1)
        colIndexer++;
    if (colTracker < col -1)
        colTracker++;
    cursorY = rowIndexer;
    if (colTracker < col )
        cursorX = colIndexer * 3;
    else
        cursorX = colTracker * 3;

}

Console.SetCursorPosition(15, 15);

