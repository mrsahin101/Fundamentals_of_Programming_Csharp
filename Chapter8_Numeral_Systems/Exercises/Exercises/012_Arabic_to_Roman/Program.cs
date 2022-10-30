/* Write a program that converts Arabic digits to Roman ones. */

void convert_Arabic_to_Roman(int arabicNumber)
{
    if (arabicNumber < 1 || arabicNumber > 3999)
        throw new ArgumentOutOfRangeException("Please enter number between 1-3999");

    Dictionary<int, string> romanMap = new Dictionary<int, string>()
    {
        {1,"I" },    {2,"II" },  {3,"III" },  {4,"IV" },  {5,"V" },   {6,"VI" },  {7,"VII" },  {8,"VIII" },    {9,"IX" },
        {10,"X" },   {20,"XX"},  {30,"XXX"},  {40,"XL"},  {50,"L"},   {60,"LX"},  {70,"LXX"},  {80,"LXXX"},    {90,"XC"},
        {100,"C" },  {200,"CC"}, {300,"CCC"}, {400,"CD"}, {500,"D"},  {600,"DC"}, {700,"DCC"}, {800,"DCCC"},   {900,"CM"},
        {1000,"M" }, {2000,"MM"},{3000,"MMM"},
    };
    int digit = 0;
    digit = arabicNumber / 1000;
    if (digit != 0)
    {
        Console.Write(romanMap[digit* 1000]);
        arabicNumber = arabicNumber - digit * 1000;
        digit = 0;
    }
    digit = arabicNumber / 100;
    if (digit != 0)
    {
        Console.Write(romanMap[digit * 100]);
        arabicNumber = arabicNumber - digit * 100;
        digit = 0;
    }
    digit = arabicNumber / 10;
    if (digit != 0)
    {
        Console.Write(romanMap[digit * 10]);
        arabicNumber = arabicNumber - digit * 10;
        digit = 0;
    }
    digit = arabicNumber / 1;
    if (digit != 0)
    {
        Console.Write(romanMap[digit * 1]);
        arabicNumber = arabicNumber - digit * 1;
        digit = 0;
    }
}
convert_Arabic_to_Roman(1543);
