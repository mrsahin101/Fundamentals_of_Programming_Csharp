/*  Write a program, which reads an integer number N from the console 
 *  and prints all combinations of K elements of numbers in range [1 … N].
 *  Example: N = 5, K = 2 -> {1, 2}, {1, 3}, {1, 4}, {1, 5}, {2, 3}, {2, 4}, {2, 5}, {3, 4}, {3, 5}, {4, 5}.
 */
Console.Write("N :");
int N = int.Parse(Console.ReadLine());

Console.Write("K :");
int K = int.Parse(Console.ReadLine());

int[] myValues = new int[K];

for (int i = 0; i < myValues.Length; i++)
{
    myValues[i] = 1;
}
void printOut()
{
    Console.WriteLine();
    Console.Write("{");
    for (int i = 0; i < myValues.Length; i++)
    {
        Console.Write(myValues[i] + ",");
    }
    Console.Write("}");
}
int numeric = 0;
int currentIndexer = 0;

while(true)
{
    for (int i = 1; i < N - K + 2; i++)
    {
        numeric = i;
        myValues[0] = numeric++;
        for (int j = 1; j < K; j++)
        {
            myValues[j] = numeric++;
        }
        printOut();
        currentIndexer = K - 1;
        while(myValues[currentIndexer] != N)
        {
            myValues[currentIndexer] += 1;
            if(myValues[currentIndexer] > N)
            {
                myValues[currentIndexer - 1] += 1;
                myValues[currentIndexer] = 0;
            }
            printOut();
        }
    }
    break;
}
