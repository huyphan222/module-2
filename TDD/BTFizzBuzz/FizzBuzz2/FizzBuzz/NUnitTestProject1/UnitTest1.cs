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
            string result = fizzbuzz.Checkinput(63);
            Assert.AreEqual(expected,result);
        }

        [Test]
        public void Test2()
        {

            string expected = "muoi hai";
            string result = fizzbuzz.Checkinput(12);
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void Test3()
        {

            string expected = "Buzz";
            string result = fizzbuzz.Checkinput(15);
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Test4()
        {

            string expected = "hai tam";
            string result = fizzbuzz.Checkinput(28);
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Test5()
        {

            string expected = "Fizz";
            string result = fizzbuzz.Checkinput(23);
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Test6()
        {

            string expected = "chin chin";
            string result = fizzbuzz.Checkinput(99);
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Test7()
        {

            string expected = "bon muoi";
            string result = fizzbuzz.Checkinput(40);
            Assert.AreEqual(expected, result);
        }

      
    }
}