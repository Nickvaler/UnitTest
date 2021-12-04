using NUnit.Framework;
using System;
using UnitTestApp;

namespace UnitTestProject1
{
    [TestFixture]
    public class TestDivision
    {
        [Test]
        //Arrange
        [TestCase(10,2, ExpectedResult = 5)]
        [TestCase(100,10, ExpectedResult = 10)]
        public double Test_Division(int a, int b)
        {
            // Act
            return Calculator.Division(a, b);
        }

        [Test]
        //Arrange
        [TestCase(10,0)]
        public void Test_Division_By_Zero(int a, int b)
        {
            // Assert
            Assert.Throws<DivideByZeroException>(() => Calculator.Division(a, b));
        }
    }
}
