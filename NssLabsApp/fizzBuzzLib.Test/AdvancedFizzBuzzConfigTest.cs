using NUnit.Framework;

namespace fizzBuzzLib.Test
{
    class AdvancedFizzBuzzConfigTest
    {
        AdvancedFizzBuzzConfig Config;

        [SetUp]
        public void Setup()
        {
            Config = new AdvancedFizzBuzzConfig();
        }

        [Test]
        public void TestAddParam()
        {
            Config.AddParam(3, "Fizz");
            Assert.IsTrue(Config.Params[0].Number == 3);
            Assert.IsTrue(Config.Params[0].Token == "Fizz");
            Assert.IsTrue(Config.Params.Count == 1);

            Config.AddParam(5, "Buzz");
            Assert.IsTrue(Config.Params[1].Number == 5);
            Assert.IsTrue(Config.Params[1].Token == "Buzz");
            Assert.IsTrue(Config.Params.Count == 2);

            Config.AddParam(15, "Duck");
            Assert.IsTrue(Config.Params[2].Number == 15);
            Assert.IsTrue(Config.Params[2].Token == "Duck");
            Assert.IsTrue(Config.Params.Count == 3);
        }
    }
}
