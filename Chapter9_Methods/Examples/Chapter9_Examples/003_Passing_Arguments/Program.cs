using System;

namespace _003_Passing_Arguments // Note: actual namespace depends on the project name.
{
    class Person
    {
        static public void PrintNameAndAge(string name, int age)
        {
            Console.WriteLine("I am {0}, {1} year(s) old.", name, age);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Person.PrintNameAndAge("John", 25);
        }
    }
    
}