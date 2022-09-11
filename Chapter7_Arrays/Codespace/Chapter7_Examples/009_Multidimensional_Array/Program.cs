int[,] intMatrix = new int[3, 4];
float[,] floatMatrix = new float[8, 2];
string[,,] stringCube = new string[5, 5, 5];

int[,] matrix =
{
    {1,2,3,4 }, // row 0
    {5,6,7,8 }  // row 1
};
// The matrix size is 2x4 = 2 rows 4 columns
for(int i = 0; i < 2; i++)
{
    for(int j= 0; j < 4; j++)
    {
        Console.WriteLine(matrix[i,j]);
    }
}