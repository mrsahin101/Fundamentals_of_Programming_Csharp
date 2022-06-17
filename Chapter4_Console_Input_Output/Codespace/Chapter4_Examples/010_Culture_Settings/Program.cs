using System;
using System.Threading;
using System.Globalization;

namespace _010_Culture_Settings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime d = new DateTime(2022, 6, 17, 21, 26, 30);
            
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("tr-TR");
            Console.WriteLine("{0:N}", 1234.56);
            /* Console Output : 1.234,560*/
            Console.WriteLine("{0:D}", d);
            /* Console Output : 17 Haziran 2022 Cuma */

            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
            Console.WriteLine("{0:N}", 1234.56);
            /* Console Output : 1,234.560*/
            Console.WriteLine("{0:D}", d);
            /* Console Output : Friday, June 17, 2022 */
        }
    }
}
