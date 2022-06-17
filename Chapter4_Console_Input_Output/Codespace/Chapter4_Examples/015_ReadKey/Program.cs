using System;

namespace _015_ReadKey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo key = Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("Character Entered: " + key.KeyChar);
            Console.WriteLine("Special Keys: " + key.Modifiers);
        }
    }
}
