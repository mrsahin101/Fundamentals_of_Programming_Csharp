/*  Write a program, which creates an array containing all Latin letters.
    The user inputs a word from the console and as result the program
    prints to the console the indices of the letters from the word.
*/

char[] myLatinLetters = {'a','b', 'c', 'd', 'e', 'f', 'g', 'h', 'i',
                            'j','k','l','m','n','o','p','q','r','s',
                                't','u','v','w','x','y','z'};

Console.Write("Word :");
string inputWord = Console.ReadLine();
int index = 0;
foreach (char ch in inputWord)
{
    for (int i = 0; i < myLatinLetters.Length; i++)
    {
        if (ch == myLatinLetters[i])
            index = i;
    }
    Console.WriteLine(ch + ": " + index);
}