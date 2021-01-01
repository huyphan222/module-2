using NUnit.Framework;
using AbsoluteCalculator.Service;

namespace AbsoluteCalculator.Test
{
    public class AbsoluteNumberCalculatorTest
    {

        private AbsoluteNumberCalulator _absoluteNumberCalulator;

        [SetUp]
        public void Setup()
        {
            _absoluteNumberCalulator = new AbsoluteNumberCalulator();
        }

        [Test]
        public void TestFindAbsolute0()
        {
            int number = 0;
            int expected = 0;

            int result = _absoluteNumberCalulator.FindAbsolute(number);
            Assert.AreEqual(expected, result);
        }
    }
}