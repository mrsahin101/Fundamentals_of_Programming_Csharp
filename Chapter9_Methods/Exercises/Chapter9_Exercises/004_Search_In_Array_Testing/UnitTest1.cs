using _004_Search_In_Array;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace _004_Search_In_Array_Testing
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            int result = _004_Search_In_Array.Program.SearchNumber(1, 1, 2, 3, 4, 1, 1, 1);
            Assert.AreEqual(4, result);
        }
    }
}