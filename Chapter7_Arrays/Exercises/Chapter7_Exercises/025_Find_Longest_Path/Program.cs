///* *Write a program, which finds in a given matrix the largest area of equal numbers. 
// * We define an area in the matrix as a set of neighbor cells (by row and column).
// * Here is one example with an area containing 13 elements with equal value of 3:
// * 
// * 1 *3* 2  2  2  4
// **3**3**3* 2  4  4
// * 4 *3* 1  2 *3**3*
// * 4 *3* 1 *3**3* 1
// * 4 *3**3**3* 1  1
// */
int[,] myArray = new int[5, 6]
{
    {1,3,2,2,2,4 },
    {3,3,3,2,4,4 },
    {4,3,1,2,3,3 },
    {4,3,1,3,3,1 },
    {4,3,3,3,1,1 }
};
//int[,] myArray = new int[5, 6]
//{
//    {0,0,0,0,0,0 },
//    {0,0,0,0,0,0 },
//    {4,1,1,2,3,3 },
//    {4,1,2,3,3,1 },
//    {4,3,1,3,1,1 }
//};
int ROW = 5;
int COL = 6;
bool[,] visited = new bool[5, 6];
int maxCount = 0;
for(int i = 0; i < ROW; i++ )
{
    for(int j = 0; j < COL; j++)
    {
        cleanVisited();
        int result = checkNeighbour(i, j) + 1;
        if(result > maxCount)
        {
            maxCount = result;
        }
    }
}
goto end;
int checkNeighbour(int i, int j)
{
    int result = 0;
    visited[i,j] = true;
    if(i - 1 >= 0)  //UP
    {
        if ((myArray[i,j] == myArray[i - 1,j]) && visited[i - 1,j] == false)
        {
            result++;
            visited[i - 1, j] = true;
            result += checkNeighbour(i-1,j);
        }
    }
    if(j - 1 >= 0)  //LEFT
    {
        if ((myArray[i, j] == myArray[i, j - 1]) && visited[i,j - 1] == false)
        {
            result++;
            visited[i, j - 1] = true;
            result += checkNeighbour(i, j - 1);
        }
    }
    if(i + 1 <= ROW - 1)    // DOWN
    {
        if ((myArray[i, j] == myArray[i + 1, j]) && visited[i + 1, j] == false)
        {
            result++;
            visited[i + 1, j] = true;
            result += checkNeighbour(i + 1, j);
        }
    }
    if(j + 1 <= COL - 1)    // RIGHT
    {
        if ((myArray[i, j] == myArray[i, j + 1]) && visited[i , j + 1] == false)
        {
            result++;
            visited[i , j + 1] = true;
            result += checkNeighbour(i , j + 1);
        }
    }
    return result ;
}
void cleanVisited()
{
    for(int i = 0; i < ROW; i++)
    {
        for(int j = 0; j < COL; j++)
        {
            visited[i,j] = false;
        }
    }
}
end:
Console.WriteLine("Calculation Done!");
Console.WriteLine("Result is : " + maxCount);