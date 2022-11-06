﻿using System;

namespace _006_Method_Overloading // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void PrintNumbers(int intValue, float floatValue)
        {

            Console.WriteLine(intValue + ";" + floatValue);
        }
        static void PrintNumbers(float floatValue, int intValue)
        {
            Console.WriteLine(floatValue + ";" + intValue);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            PrintNumbers(2.71f, 2);

            PrintNumbers(5, 3.14159f);
        }
    }

}