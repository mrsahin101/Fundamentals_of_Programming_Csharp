namespace _004_Search_In_Array
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write(SearchNumber(1, 1, 2, 3, 1, 1));
        }
        public static int SearchNumber(int searchedNumber, params int[] numbers)
        {
            int counter = 0;
            for(int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == searchedNumber)
                    counter++;
            }
            return counter;
        }
    }
}