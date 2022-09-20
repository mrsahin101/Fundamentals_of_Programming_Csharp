/* Write a program, which creates square matrices like those in the figures below
 * and prints them formatted to the console. The size of the matrices will be read from the console.
 * See the examples for matrices with size of 4 x 4 and make the other sizes in a similar fashion: 
 * 
 * 4 x 4 
 * 
 * 1  8  9   16
 * 2  7  10  15
 * 3  6  11  14
 * 4  5  12  13
 */
Console.Write("Col count :");
int col = int.Parse(Console.ReadLine());

Console.Write("Row Count :");
int row = int.Parse(Console.ReadLine());

Console.WriteLine();
Console.WriteLine();

int number = 1;
int cursorX = 0;
int cursorY = 0;
Console.Clear();
for (int i = 0; i < col; i++)
{
    for (int j = 0; j < row; j++)
    {
        Console.SetCursorPosition(cursorX, cursorY);
        Console.Write(number);
        number++;
        
        if (i % 2 == 0)
            cursorY++;
        else
            cursorY--;
            
    }
    cursorX += 3;
    if (i % 2 == 0)
        cursorY--;
    else
        cursorY++;
}
Console.SetCursorPosition(15, 15);