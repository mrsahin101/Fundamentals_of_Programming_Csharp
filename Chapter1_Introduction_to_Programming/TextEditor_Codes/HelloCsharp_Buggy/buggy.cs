class Buggy
{
    static void Main(string[] args)
    {
        /*We can throw exception and hello c# print out didnt executed because
        before that exception happened */
        throw new System.NotImplementedException("Intented Exception.");
        System.Console.WriteLine("Hello C#");
    }
}