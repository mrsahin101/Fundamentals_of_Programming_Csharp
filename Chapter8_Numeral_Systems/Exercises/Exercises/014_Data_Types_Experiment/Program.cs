/* Try adding up 50,000,000 times the number 0.000001. Use a loop and addition (not direct multiplication). 
 * Try it with float and double and after that with decimal. 
 * Do you notice the huge difference in the results and speed of calculation? Explain what happens.
 */
using System;

float myFloatSum = 0;
for(Int32 i = 0; i < 50000000; i++)
{
    myFloatSum += 0.000001f;
}
Console.WriteLine(myFloatSum);

double myDoubleSum = 0;
for (Int32 i = 0; i < 50000000; i++)
{
    myDoubleSum += 0.000001d;
}
Console.WriteLine(myDoubleSum);

decimal myDecimalSum = 0;
for (Int32 i = 0; i < 50000000; i++)
{
    myDecimalSum += 0.000001m;
}
Console.WriteLine(myDecimalSum);