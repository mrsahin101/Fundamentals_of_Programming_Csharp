float total = 5.0f;
float result = 5.0f;
double sum = 10.0;
double div = 35.4 / 3.0;
double x = 5d;

double d = 0;
Console.WriteLine(d);
Console.WriteLine(1 / d);
Console.WriteLine(-1 / d);
Console.WriteLine(d / d);

float mySum = 0f;
for(int i = 0; i <1000; i++)
{
    mySum += 0.1f;
}
Console.WriteLine("Sum : {0}", mySum);
// Sum : 99.99905

double anotherSum = 0.0;
for(int i = 1; i <= 10; i++)
{
    anotherSum += 0.1;
}
Console.WriteLine("{0:r}", anotherSum);
Console.WriteLine(anotherSum);

float differentSum = 0.0f;
for (int i = 1; i <= 10; i++)
{
    differentSum += 0.1f;
}
Console.WriteLine("{0:r}", differentSum);
Console.WriteLine(differentSum);

decimal decimalSum = 0.0m;
for (int i = 1; i <= 10; i++)
{
    decimalSum += 0.1m;
}
Console.WriteLine(decimalSum);
