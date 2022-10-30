/* Write a program that by given N, S, D (2 ≤ S, D ≤ 16) 
 * converts the number N from an S-based numeral system to a D based numeral system.
 */
using System.Globalization;
using System.Text;

void convert_Base_S_to_Base_D(string number, int baseS, int BaseD)
{
    Dictionary<int, string> digitArray = new Dictionary<int, string>()
    {
        {1, "1"},   {2, "2" },  {3,"3"},    {4, "4"},   {5, "5"},   {6, "6"},   {7,"7" },   {8,"8"},
        {9,"9"},    {10,"A" },  {11,"B"},   {12,"C"},   {13,"D"},   {14,"E"},   {15,"F"}
    };
    int decimalNumber = 0;
    Console.WriteLine("Base " + baseS + " number : " + number);
    for (int i = number.Length - 1,index = 0 ; i >= 0; i--,index++)
    {
        decimalNumber += (int.Parse(number[i].ToString()) * int.Parse((Math.Pow(baseS,index)).ToString()));
    }
    Console.WriteLine("Decimal equvilant : " + decimalNumber);

    StringBuilder myStrBuilder = new StringBuilder();
    for(int index = 0; decimalNumber > 0; index++)
    {
        int digit = decimalNumber % BaseD;
        decimalNumber = decimalNumber / BaseD;
        myStrBuilder.Insert(0, digitArray[digit]);
    }
    Console.WriteLine(myStrBuilder.ToString());
}
convert_Base_S_to_Base_D("11111", 2,16);
