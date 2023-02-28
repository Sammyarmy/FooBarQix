using NUnit.Framework;

namespace FooBarQix
{
    public class Tests
    {
        [Test]
        [TestCase("33", "FooFooFoo")]
        [TestCase("15", "FooBarBar")]
        [TestCase("8", "8")]
        [TestCase("21", "FooQix")]
        public void testCompute(string input, string expected)
        {
            Compute compute = new Compute();
            Assert.AreEqual(expected, compute.compute(input));
        }
        [Test]
        [TestCase("101", "1*1")] // this test case fails with "*101", this is due to the way I've written the algorithm doesnt expect to need to replace chars if not divisible or containing 3,5,7
        [TestCase("303", "FooFoo*Foo")]
        [TestCase("105", "FooBarQix*Bar")]
        [TestCase("10101", "FooQix**")]
        public void testZeroes(string input, string expected)
        {
            Compute compute = new Compute();
            Assert.AreEqual(expected, compute.compute(input));
        }

    }
}
