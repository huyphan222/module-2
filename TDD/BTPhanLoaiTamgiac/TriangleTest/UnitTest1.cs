using NUnit.Framework;
using Triangle;

namespace TriangleTest
{
    public class Tests
    {
        private TriangleClassifier triangle;
        [SetUp]
        public void Setup()
        {
            triangle = new Triangle.TriangleClassifier();
        }

        [Test]
        public void Test1()
        {
            
            string expected = "Tam giac deu";
            string result = triangle.Check(2, 2, 2);
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Test2()
        {

            string expected = "Tam giac can";
            string result = triangle.Check(3,4 , 4);
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Test3()
        {

            string expected = "Tam giac";
            string result = triangle.Check(4, 2, 5);
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Test4()
        {

            string expected = "Khong phai tam giac";
            string result = triangle.Check(-1, 1, 5);
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Test5()
        {

            string expected = "Khong phai tam giac";
            string result = triangle.Check(8, 2, 2);
            Assert.AreEqual(expected, result);
        }
    }
}