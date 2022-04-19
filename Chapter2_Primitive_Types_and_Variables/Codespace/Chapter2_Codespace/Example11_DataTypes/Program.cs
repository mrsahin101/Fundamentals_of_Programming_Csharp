using System;

namespace Example11_DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Create int variable and allocate memory in stack */
            int i = 42;
            /* Create char variable and allocate memory in stack */
            char ch = 'A';
            /* Create bool variable and allocate memory in stack */
            bool result = true;
            /* Create obj int variable on heap and create reference for that int in stack */
            object obj = 42;
            /* Create string variable on heap and create reference to that string in stack */
            string str = "Hello";
            /* Create byte variable on heap and create reference to that byte array in stack */
            byte[] bytes = { 1, 2, 3, 4 };


            /* When we re-assign value to i directly it changes in stack */ 
            i = 0;
            /* When we re-assign value to ch directly it changes in stack */
            ch = 'B';
            /* When we re-assign value to result directly it changes in stack */
            result = false;
            /* When we re-assign null to obj reference, basicly it stops pointing to that value in the heap. After while
             * if we still dont  refere to that point it will be collected by garbage collector and deallocated. But it's not exact
             * when that happens*/
            obj = null;
            /* When we write Bye into string basicly it goes to heap and create new value contain Bye string. then change that 
             * reference in stack to point that. The old value (which contains "Hello" in heap remain un-referenced.
             * After some time garbage collector will collect that value and free memory if it stays un-used.
             */
            str = "Bye";
            /* Reference still pointing same place on memory but it goes there and goes to 2nd item (index 1) and change it'S value */
            bytes[1] = 0;
        }
    }
}
