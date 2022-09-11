int[][] jaggedArray;

jaggedArray = new int[2][];
jaggedArray[0] = new int[5];
jaggedArray[1] = new int[3];


int[][] myJaggedArray = {
new int[] {5, 7, 2},
new int[] {10, 20, 40},
new int[] {3, 25}
};
for(int i = 0; i < myJaggedArray.Length; i++)
{
    for(int j = 0; j < myJaggedArray[i].Length ; j++)
    {
        Console.Write(myJaggedArray[i][j]+ ",");
    }
    Console.WriteLine();
}