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
        [TestCase("101", "1*1")]
        [TestCase("303", "FooFoo*Foo")]
        [TestCase("105", "FooBarQix*Bar")]
        [TestCase("10101", "FooQix**")]
        public void testZeroes(string input, string output)
        {
            Compute compute = new Compute();
            Assert.AreEqual(output, compute.compute(input));
        }

    }
}
