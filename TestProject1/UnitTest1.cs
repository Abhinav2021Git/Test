//using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Dummy;

namespace TestProject1
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {
            Class1.num1 = 5.50d;//arrange
            Class1.num2 = 2.50d;//arrange
            Class1.Sum(Class1.num1, Class1.num2);//act
            Assert.AreEqual(8.00d, Class1.sum); //assert


        }
    }
}
