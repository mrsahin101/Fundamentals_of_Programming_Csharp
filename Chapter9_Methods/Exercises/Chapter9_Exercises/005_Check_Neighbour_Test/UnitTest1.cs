namespace _005_Check_Neighbour_Test
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
            bool result = Program.GreaterThanNeighbours(1, 0, 1, 0, 2, 3, 4);
            Assert.That(result,Is.EqualTo(true));
        }
    }
}