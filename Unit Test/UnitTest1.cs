using Calculator___Testing;

namespace Unit_Test
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
            Assert.That(myCalculator.add(2, 3), Is.EqualTo(5));
        }
        [Test] 
        public void Test2()
        {
            Assert.That(myCalculator.subtract(10,3), Is.EqualTo(7));
        }
        [Test] 
        public void Test3()
        {
            Assert.That(myCalculator.multiply(2, 2), Is.EqualTo(4));
        }
        [Test]
        public void Test4()
        {
            Assert.That(myCalculator.divide(7, 2), Is.EqualTo(3));
        }
        [Test]
        public void Test5()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                Console.SetIn(new StringReader("a\r2\r2\r"));
                myCalculator.Menu();
                var result = sw.ToString().Trim();
                Assert.That(result, Is.EqualTo("4"));
            }
        }
    }
}