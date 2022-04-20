using System;
/* Question : 
 * Write a program, which compares correctly two real numbers with accuracy at least 0.000001.
 */
namespace Example3_Compare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Since double has like 15-16 digit precision we can use double for this type of comparision */
            double firstNumber = 0.000001;
            double secondNumber = 0.000002;
            if(firstNumber - secondNumber == 0)
                Console.WriteLine("Failed! Result : " + (secondNumber - firstNumber));
            else
                Console.WriteLine("Successed! Result : " + (secondNumber - firstNumber));

            /* Console Output :
             * Successed! Result : 1E-06
             */
        }
    }
}
