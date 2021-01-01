using NUnit.Framework;
using FizzBuzz;

namespace NUnitTestProject1
{
    public class Tests
    {
        private FizzBuzzTranslate fizzbuzz;
        [SetUp]
        public void Setup()
        {
          fizzbuzz = new FizzBuzzTranslate();
        }

        [Test]
        public void Test1()
        {

            string expected = "Fizz";
            string result = fizzbuzz.TranslateN(12);
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void Test2()
        {

            string expected = "Buzz";
            string result = fizzbuzz.TranslateN(50);
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void Test3()
        {

            string expected = "FizzBuzz";
            string result = fizzbuzz.TranslateN(15);
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Test4()
        {

            string expected = "2";
            string result = fizzbuzz.TranslateN(2);
            Assert.AreEqual(expected, result);
        }
    }
}