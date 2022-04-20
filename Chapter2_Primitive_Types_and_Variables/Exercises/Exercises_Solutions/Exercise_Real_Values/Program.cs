using System;
/* Question:
 * Which of the following values can be assigned to variables of type float, double and decimal:
 * 5, -5.01, 34.567839023; 12.345; 8923.1234857; 3456.091124875956542151256683467?
 */
namespace Exercise_Real_Values
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Since precision matter and also decimal is totaly run by software we have to choose our data type carefully
             * for best performance.
             * For small values and lower than 6 decimal point after dot we can use float. 
             * for numbers has less than 16 digit after dot we use double.
             * for huge numbers many after digit we use decimal. We dont get rounding erros with decimal but then again
             * because its software driven its going to be slow calculation compare to other. 
             * if precision matter decimal could be the way to go especially when we have many digits after dot.
             * otherwise if performance matter then float or double could be right fit*/
            float five = 5;
            Console.WriteLine(five);
            /* Console Output :
             * 5
             */
            float fivetwo = -5.01f;
            Console.WriteLine(fivetwo);
            /* Console Output :
             * -5,01
             */
            double thirtyfive = 34.567839023;
            Console.WriteLine(thirtyfive);
            /* Console Output :
             * 34,567839023
             */
            float twelwe = 12.345f;
            Console.WriteLine(twelwe);
            /* Console Output :
             * 12,345
             */
            double eigthtyk = 8923.1234857;
            Console.WriteLine(eigthtyk);
            /* Console Output :
             * 8923,1234857
             */
            decimal hugenumber = 3456.091124875956542151256683467m;
            Console.WriteLine(hugenumber);
            /* Console Output :
             * 3456,0911248759565421512566835
             */
        }
    }
}
