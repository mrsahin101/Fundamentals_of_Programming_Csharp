using System;
/* Question :* Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation. Examples:
- 0 --> "Zero"
- 12 --> "Twelve"
- 98 --> "Ninety eight"
- 273 --> "Two hundred seventy three"
- 400 --> "Four hundred"
- 501 --> "Five hundred and one"
- 711 --> "Seven hundred and eleven"
 
 */

namespace _011_Pronunciation_of_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int theNumber = 711;
            string[] firstTwenty = new string[] {"Zero","One","Two","Three","Four","Five","Six","Seven","Eight","Nine",
                "Ten","Eleven","Twelwe","Thirteen","Fourteen","Fifteen","Sixteen","Seventeen","Eighteen","Nineteen","Twentry" };

            string[] tenthsNumbers = new string[] {"","", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
            
            string[] digits = new string[] { "", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };

            string[] hundreds = new string[] { "One-hundred", "Two-hundred", "Three-hundred", "Four-hundred", "Five-hundred",
                "Six-hundred", "Seven-hundred", "Eight-hundred", "Nine-hundred" };

            if (theNumber >= 0 && theNumber <= 20)
                Console.WriteLine("The number {0} pronunciation is : {1}", theNumber, firstTwenty[theNumber]);
            else if (theNumber >= 20 && theNumber <= 99)
            {
                Console.Write("The number {0} pronunciation is : ",theNumber);
                int tents = theNumber /10;
                Console.Write(tenthsNumbers[tents]);
                int digit = theNumber - (tents * 10);
                Console.Write("-" + digits[digit]);
            }
            else if (theNumber >= 100 && theNumber <= 999)
            {
                int hundred = theNumber / 100;
                int ten = (theNumber - (hundred * 100)) / 10;
                int digit = (theNumber - (hundred * 100) - (ten * 10));
                Console.Write("The number {0} pronunciation is : ", theNumber);

                Console.Write(hundreds[hundred - 1]);

                if (ten > 2)
                {
                    Console.Write(" " + tenthsNumbers[ten]);
                    Console.Write(" " + digits[digit]);
                }
                else
                {
                    int output = theNumber - ((theNumber / 100) *100) ;
                    Console.Write(" " + firstTwenty[output]);
                }
                
            }

        }
    }
}
