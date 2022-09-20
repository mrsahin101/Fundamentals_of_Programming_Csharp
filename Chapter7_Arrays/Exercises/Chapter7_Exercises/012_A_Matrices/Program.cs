/* Write a program, which creates square matrices like those in the figures below
 * and prints them formatted to the console. The size of the matrices will be read from the console.
 * See the examples for matrices with size of 4 x 4 and make the other sizes in a similar fashion: 
 * 
 * 4 x 4 
 * 
 * 1  5  9   13
 * 2  6  10  14
 * 3  7  11  15
 * 4  8  12  16
 */

Console.Write("Col count :");
int col = int.Parse(Console.ReadLine());

Console.Write("Row Count :");
int row = int.Parse(Console.ReadLine());

Console.WriteLine();
Console.WriteLine();

int number = 1;
int cursorX = 0;
int cursorY = 4;
for (int i = 0; i < col; i++)
{
    for (int j = 0; j < row; j++)
    { 
        Console.SetCursorPosition(cursorX, cursorY);
        Console.Write(number);
        number++;
        cursorY++;
        
    }
    cursorY = 4;
    cursorX += 3;
}



