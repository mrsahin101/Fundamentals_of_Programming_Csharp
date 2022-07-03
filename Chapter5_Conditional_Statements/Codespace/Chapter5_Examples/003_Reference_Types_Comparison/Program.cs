using System;

namespace _003_Reference_Types_Comparison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "beer";
            string anotherStr = str;
            string thirdStr = "bee";
            thirdStr = thirdStr + "r";
            
            Console.WriteLine("str = {0}",str);
            /* Console Output : str = beer
             */
            Console.WriteLine("anotherStr = {0}", anotherStr);
            /* Console Output : anotherStr = beer
             */
            Console.WriteLine("thirdStr = {0}", thirdStr);
            /* Console Output : thirdStr = beer
             */

            Console.WriteLine(str == anotherStr); // this returns true because their content is same. Also they refere to same object
            /* Console Output : True
             */

            Console.WriteLine(str == thirdStr); // this returns true because their content is same. They refere different object
            /* Console Output : True
             */

            Console.WriteLine((object) str == (object)anotherStr); // true because pointing same object
            /* Console Output : True
             */

            Console.WriteLine((object)str == (object)thirdStr); // false because they point different object
            /* Console Output : False
             */
        }
    }
}
