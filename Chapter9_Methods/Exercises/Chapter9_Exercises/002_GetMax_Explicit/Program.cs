namespace _002_GetMax_Explicit
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("First Number : ");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.Write("Second Number :");
            int secondNumber = int.Parse(Console.ReadLine());

            Console.Write("Third Number :");
            int thirdNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Maximum number is :" + GetMax(firstNumber, GetMax(secondNumber, thirdNumber)));
        }
        public static int GetMax(int firstNumber, int secondNumber)
        {
            if (firstNumber > secondNumber)
                return firstNumber;
            else
                return secondNumber;
        }
    }
}