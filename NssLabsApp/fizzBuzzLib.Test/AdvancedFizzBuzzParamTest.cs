using System;
using NUnit.Framework;


namespace fizzBuzzLib.Test
{
    class AdvancedFizzBuzzParamTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(3, 5, false)]
        [TestCase(3, 6, true)]
        [TestCase(5, 15, true)]
        [TestCase(5, 21, false)]
        [TestCase(0, 0, false)]
        [TestCase(1, 0, true)]
        [TestCase(0, 1, false)]
        public void TestMatches(int number, int value, bool result)
        {
            AdvancedFizzBuzzParam param = new AdvancedFizzBuzzParam
            {
                Number = number,
                Token = "Fizz"
            };
            Assert.AreEqual(param.Matches(value), result);
        }
    }
}
