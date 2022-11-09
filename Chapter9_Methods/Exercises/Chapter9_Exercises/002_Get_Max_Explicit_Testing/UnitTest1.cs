
using NUnit.Framework;
//using NUnit.Framework.Internal;
using System;
//using Assert = NUnit.Framework.Assert;

namespace _002_Get_Max_Explicit_Testing
{
    
    public class Tests
    {

        [Test]
        public void Test1()
        {
            int result = Program.GetMax(1, 5);
            Assert.AreEqual(5, result);
        }
    }
}