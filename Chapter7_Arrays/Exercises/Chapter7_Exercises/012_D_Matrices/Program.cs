/* Write a program, which creates square matrices like those in the
 * figures below and prints them formatted to the console. The size of the
 * matrices will be read from the console. See the examples for matrices
 * with size of 4 x 4 and make the other sizes in a similar fashion:
 *
 * 1  12 11  10
 * 2  13 16  9
 * 3  14 15  8 
 * 4  5  6   7
 */
// first line
Console.Write("Col : ");
int col = int.Parse(Console.ReadLine());
// second line
Console.Write("Row : ");
int row = int.Parse(Console.ReadLine());


int CursorX = 0;
int CursorY = 4;
int number = 1;
int maxNumber = row * col;
for (int i = 0; i < row; i++)
{
    Console.SetCursorPosition(CursorX, CursorY);
    Console.Write(number);
    number++;
    CursorY++;
}
CursorY--;
row--;
col--;
CursorX += 3;
while (true)
{
    // to right
    for (int i = 0; i < col; i++)
    {
        Console.SetCursorPosition(CursorX, CursorY);
        Console.Write(number);
        number++;
        CursorX += 3;
    }
    CursorX -= 3;
    CursorY--;
    // to up
    for (int i = 0; i < row; i++)
    {
        Console.SetCursorPosition(CursorX, CursorY);
        Console.Write(number);
        number++;
        CursorY--;
    }
    row--;
    col--;
    CursorY++;
    CursorX -= 3;
    // to left
    for (int i = 0; i < col; i++)
    {
        Console.SetCursorPosition(CursorX, CursorY);
        Console.Write(number);
        number++;
        CursorX -= 3;
    }
    CursorX += 3;
    CursorY++;
    // to down
    for (int i = 0; i < col; i++)
    {
        Console.SetCursorPosition(CursorX, CursorY);
        Console.Write(number);
        number++;
        CursorY++;
    }
    CursorY--;
    CursorX += 3;
    row--;
    col--;
    if (number >= maxNumber)
        break;
}
Console.SetCursorPosition(15, 15);
return 0;

