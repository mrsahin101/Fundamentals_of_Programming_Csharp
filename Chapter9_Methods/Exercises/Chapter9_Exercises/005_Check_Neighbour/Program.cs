namespace _005_Check_Neighbour
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GreaterThanNeighbours(1,0,1,0,2));

        }
        public static bool GreaterThanNeighbours(int index, params int[] numbers)
        {
            if (numbers.Length < 1)
                return false;
            if(index == 0)
            {
                if (numbers[index] > numbers[index + 1])
                    return true;
                else
                    return false;
            }
            if(index == numbers.Length - 1)
            {
                if (numbers[index] > numbers[index - 1])
                    return true;
                else
                    return false;
            }
            if (numbers[index] > numbers[index -1] && numbers[index] > numbers[index + 1])
                return true;
            else
                return false;
        }
    }
}