namespace _006_First_Occurence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(firstOccurenceFinder(1, 1, 3, 1, 1));
            
        }
        static int firstOccurenceFinder(params int[] myArray)
        {
            int foundIndex = -1;
            for(int i = 1; i < myArray.Length - 1; i++)
            {
                if(myArray[i] > myArray[i - 1] && myArray[i] > myArray[i + 1])
                {
                    foundIndex = i;
                    break;
                }
            }
            return foundIndex;
        }
    }
}