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
        public void testCompute(string input, string output)
        {
            Compute compute = new Compute();
            Assert.AreEqual(compute.compute(input), output);
        }

    }
}
