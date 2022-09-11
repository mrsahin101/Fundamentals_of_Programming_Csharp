Console.Write("Enter Rows Count :");
int row = int.Parse(Console.ReadLine());

Console.Write("Enter Columns Count :");
int col = int.Parse(Console.ReadLine());    

int[,] matrix = new int[row, col];
Console.WriteLine();
Console.WriteLine("Enter each cell of matrix:");

for(int i = 0; i < matrix.GetLength(0); i++)
{
    for(int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write("Enter " + i + "th row, " + j + "th col :");
        matrix[i, j] = int.Parse(Console.ReadLine());
    }
}

for(int i = 0; i < matrix.GetLength(0); i++)
{
    for(int j= 0; j < matrix.GetLength(1); j++)
    {
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}