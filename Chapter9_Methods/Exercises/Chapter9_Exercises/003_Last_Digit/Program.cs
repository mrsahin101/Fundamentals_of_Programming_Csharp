static void lastDigit(int number)
{
    string[] names = new string[] { "Zero","One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
    int lastDigit = number % 10;
    Console.WriteLine("Last digit is {0}",names[lastDigit]);
}
lastDigit(153);