int integerValue = 25;
Console.WriteLine(integerValue);

int integerHexValue = 0x2A;
Console.WriteLine(integerHexValue);

int y = Convert.ToInt32("1001", 2);
Console.WriteLine(y);

long myLongVar = 9223372036854775807L;
Console.WriteLine(myLongVar);

long newLongValue = 931456999054323689l;
Console.WriteLine(newLongValue);

// this makes sure the value is checked and it throwing exception when overflow occurs.
// if we dont use checked block then it would print out -2147483648
checked
{
    int a = int.MaxValue;
    a = a+1;
    Console.WriteLine(a);
}