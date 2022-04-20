using System;

namespace Example12_Literals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* This 2 variable initialized literaly with 2 exactly same value. */
            int numberInDec = 16;
            int numberInHex = 0x10;

            /* This will cause error because the value 234L isn't integer*/
            //int longInt = 234L;

            /* REAL LITERALS */
            /* This 2 variable has initialized with same exact value */
            float realNumbers = 12.5f;
            float realNumberInScientific = 1.25e+1f;

            /* CHARACTER LITERALS */
            char character = 'a';
            Console.WriteLine(character);
            /* Console Output: 
             * a
             */

            /* Unicode character code in a hexdecimal format */
            char unicodech = '\u003A';
            Console.WriteLine(unicodech);
            /* Console output :
             * :
             */
            char quotation = '\'';
            Console.WriteLine(quotation);
            /* Console output :
             * '
             */
            char backslash = '\\';
            Console.WriteLine(backslash);
            /* Console output :
             * \
             */
            /* STRING LITERALS */
            string quotations = "\"Hello, Jude\", he said.";
            Console.WriteLine(quotations);
            /* Console output :
             * "Hello, Jude", he said.
             */
            string path = "C:\\Windows\\Notepad.exe";
            Console.WriteLine(path);
            /* Console output :
             * C:\Windows\Notepad.exe
             */
            string verbatim = @"The \ is not escaped as \\.
            I am at new line.";
            Console.WriteLine(verbatim);
            /* Console output: 
             * The \ is not escaped as \\.
             * I am at new line.
             */
        }
    }
}
