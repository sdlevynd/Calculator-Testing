using Calculator___Testing;

namespace Unit_Tests
{
    public class Tests
    {
        Calculator myCalculator;
        [SetUp]
        public void Setup()
        {
            myCalculator = new Calculator();
        }

        [Test]
        public void Test1()
        {
            Assert.That(myCalculator.add(2,2).Equals(4));
        }
    }
}