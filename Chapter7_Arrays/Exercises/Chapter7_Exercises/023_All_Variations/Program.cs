/* Write a program, which reads the integer numbers N and K
 * from the console and prints all variations of K elements of the numbers in the interval [1…N]. 
 * Example: N = 3, K = 2  {1, 1}, {1, 2}, {1, 3}, {2, 1}, {2, 2}, {2, 3}, {3, 1}, {3, 2}, {3, 3}.
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
goto mylabel;
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
mylabel:
myValues[K - 1] = 0;
while (true)
{
    for(int i = 0; i < N; i++)
    {
        myValues[K - 1] += 1;
        printOut();
    }
    for(int i = 0; i < K; i++)
    {
        if(N == myValues[i])
        {
            if (i == 0)
                goto end;
            else
            {
                myValues[i - 1] += 1;
                myValues[i] = 0;
            }
        }
    }
}
end:
Console.WriteLine();
Console.WriteLine();
Console.Write("Computation done!");