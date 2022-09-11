/* * Write a program that for a given number n, outputs a matrix in the form of a spiral:
 *          n : 4
 *          1  2  3  4
 *          12 13 14 5
 *          11 16 15 6
 *          10 9  8  7
 */


/* the pattern for spirall seems like first step: 
 *        - go n to right direction
 *          set step to n
 *          while (total step <= n * n)
 *              set step to step minus one
 *              go to down step times
 *              go to left step times
 *              
 *              set step to step minus one
 *              go to up step times
 *              go to right step times
 *      
 */
const int xStep = 3;
const int yStep = 1;

Console.Write("n :");
int n = int.Parse(Console.ReadLine());

int cursorX = 0;
int cursorY = 0;

Console.Clear();

int number = 1;

int sudo_n = n;


for (int i = 0; i < n; i++)
{
    if(i != 0)
    {
        number++;
        cursorX += xStep;
    }
    Console.SetCursorPosition(cursorX, cursorY);
    Console.Write(number);
    
}

while (number <= (n * n))
{
    sudo_n--;
    for(int i = 0; i < sudo_n; i++)
    {
        number++;
        cursorY += yStep;
        Console.SetCursorPosition(cursorX, cursorY);
        Console.Write(number);
        
    }
    for (int i = 0; i < sudo_n; i++)
    {
        number++;
        cursorX -= xStep;
        Console.SetCursorPosition(cursorX, cursorY);
        Console.Write(number);
        
    }
    sudo_n--;

    for (int i = 0; i < sudo_n; i++)
    {
        number++;
        cursorY -= yStep;
        Console.SetCursorPosition(cursorX, cursorY);
        Console.Write(number);
        
    }

    for (int i = 0; i < sudo_n; i++)
    {
        number++;
        cursorX += xStep;
        Console.SetCursorPosition(cursorX, cursorY);
        Console.Write(number);
        
    }

}
