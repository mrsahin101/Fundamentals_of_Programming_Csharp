using System;

namespace Example10_Nullable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Example of how to declare nullable types*/
            Nullable<int> i1 = null;
            int? i2 = i1;


            /* Declare int variable */
            int i = 5;

            /* Declare nullable int( basicly int pointer in C) */
            int? ni = i;
            Console.WriteLine(ni);
            /* Console Output: 
             * 5
             */
            /* if we do i = ni it will fail to compile*/

            Console.WriteLine(ni.HasValue);
            /* Console Output: 
             * True
             */
            /* But we can assign i with ni.value */
            i = ni.Value;
            Console.WriteLine(i);
            /* Console Output: 
             * 5
             */

            /* lets set ni to null*/
            ni = null;
            Console.WriteLine(ni.HasValue);
            /* Console Output: 
             * False
             */
            /* Now if we try to do i = ni.Value it will Give us System.InvalidOperationException error
             * Unhandled exception. System.InvalidOperationException: Nullable object must have a value.*/
            
            i = ni.GetValueOrDefault();
            /* i equal to either to 0 ( which means ni is null ) or if ni has value it will get assigned that value */
            Console.WriteLine(i);
            /* Console Output: 
             * 0
             */
            /* We get 0 because ni was equal to null so we get 0 assigned to i */
        }
    }
}
