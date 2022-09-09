/* Write a program that prints all possible cards from a standard deck of cards,
 * without jokers (there are 52 cards: 4 suits of 13 cards).
 */

string[] myCards = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Q", "K" };
string[] mySymbols = { "\u2660", "\u2665", "\u2666", "\u2663" };

for(int i = 0; i < mySymbols.Length; i++)
{
    for(int j = 0; j < myCards.Length; j++)
    {
        Console.Write(mySymbols[i] + myCards[j] + ", ");
    }
    Console.WriteLine();
}