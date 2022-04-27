using System;
/* Question:
 * The gravitational field of the Moon is approximately 17% of that on the Earth.
 * Write a program that calculates the weight of a man on the moon by a given weight on the Earth.
 */
namespace Exercise7_Moon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double worldGraviton = 9.8d;
            double moonGraviton = 9.8d * 0.17;

            
            string weight = "a";
            int intWeight = 0;
            while(!int.TryParse(weight, out intWeight))
            {
                Console.WriteLine("Please Enter Man weight in the world!");
                weight = Console.ReadLine();
            }
            double mass = intWeight / worldGraviton;
            double moonWeight = mass * moonGraviton;
            Console.WriteLine("This Man will weight " + moonWeight + " at the Moon!");
        }
    }
}
