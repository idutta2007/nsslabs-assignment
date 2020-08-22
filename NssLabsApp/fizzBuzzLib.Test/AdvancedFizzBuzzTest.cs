using NUnit.Framework;
using System.ComponentModel;
using System.Linq;
using System.Net.Http.Headers;

namespace fizzBuzzLib.Test
{
    public class AdvancedFizzBuzzTest
    {
        [SetUp]
        public void Setup()
        {
        }

        /**
         * Basic test with numbers in range 1..100
         */
        [Test]
        public void Test1()
        {
            AdvancedFizzBuzzConfig config = new AdvancedFizzBuzzConfig();
            config.AddParam(3, "Fizz");
            config.AddParam(5, "Buzz");

            var generator = new AdvancedFizzBuzz(config);
            var result = generator.generateFizzBuzz(Enumerable.Range(1, 100).ToArray());

            Assert.IsTrue(result.Count == 100);
            Assert.AreEqual( result[2], "Fizz" );
            Assert.AreEqual( result[4], "Buzz" );
            Assert.AreEqual( result[14], "FizzBuzz" );
            Assert.AreEqual( result[44], "FizzBuzz" );
            Assert.AreEqual( result[84], "Buzz" );
            Assert.AreEqual( result[89], "FizzBuzz" );
            Assert.AreEqual( result[98], "Fizz" );

        }

        /**
        * Test with custom tokens
        */
        [Test]
        public void Test2()
        {
            AdvancedFizzBuzzConfig config = new AdvancedFizzBuzzConfig();
            config.AddParam(5, "Cat");
            config.AddParam(13, "Duck");
            config.AddParam(6, "Chicken");

            var generator = new AdvancedFizzBuzz(config);
            var result = generator.generateFizzBuzz(5, 13, 6, 65, 30, 390 );

            Assert.IsTrue(result.Count == 6);
            Assert.AreEqual(result[0], "Cat");
            Assert.AreEqual(result[1], "Duck");
            Assert.AreEqual(result[2], "Chicken");
            Assert.AreEqual(result[3], "CatDuck");
            Assert.AreEqual(result[4], "CatChicken");
            Assert.AreEqual(result[5], "CatDuckChicken");

        }

        /**
         *  Test with non-sequential positive and negative numbers
         */
        [Test]
        public void Test3()
        {
            AdvancedFizzBuzzConfig config = new AdvancedFizzBuzzConfig();
            config.AddParam(3, "Fizz");
            config.AddParam(5, "Buzz");

            var generator = new AdvancedFizzBuzz(config);
            var result = generator.generateFizzBuzz(-11, 102, 13, -15, -89, 36, 85, 25, 17, 99, 0);

            Assert.AreEqual(result.Count, 11);

            Assert.AreEqual(result[0], "-11");
            Assert.AreEqual(result[1], "Fizz");
            Assert.AreEqual(result[2], "13");
            Assert.AreEqual(result[3], "FizzBuzz");
            Assert.AreEqual(result[4], "-89");
            Assert.AreEqual(result[5], "Fizz");
            Assert.AreEqual(result[6], "Buzz");
            Assert.AreEqual(result[7], "Buzz");
            Assert.AreEqual(result[8], "17");
            Assert.AreEqual(result[9], "Fizz");
            Assert.AreEqual(result[10], "FizzBuzz");

        }

        /**
         * Test with prime numbers
         */
        [Test]
        public void Test4()
        {
            AdvancedFizzBuzzConfig config = new AdvancedFizzBuzzConfig();
            config.AddParam(3, "Fizz");
            config.AddParam(5, "Buzz");

            var generator = new AdvancedFizzBuzz(config);
            var result = generator.generateFizzBuzz( 7727, 7741, 7753, 7757, 7759, 7789, 7793, 7817 );

            Assert.AreEqual(result.Count, 8);

            Assert.AreEqual(result[0], "7727");
            Assert.AreEqual(result[1], "7741");
            Assert.AreEqual(result[2], "7753");
            Assert.AreEqual(result[3], "7757");
            Assert.AreEqual(result[4], "7759");
            Assert.AreEqual(result[5], "7789");
            Assert.AreEqual(result[6], "7793");
            Assert.AreEqual(result[7], "7817");

        }

        /**
        * Provide input numbers as an array
        */
        [Test]
        public void Test5()
        {
            AdvancedFizzBuzzConfig config = new AdvancedFizzBuzzConfig();
            config.AddParam(3, "Fizz");
            config.AddParam(5, "Buzz");

            var generator = new AdvancedFizzBuzz(config);
            var result = generator.generateFizzBuzz(new int[] { 3, 4, 5, 15, 17, 29 });

            Assert.AreEqual(result.Count, 6);
            Assert.AreEqual(result[0], "Fizz");
            Assert.AreEqual(result[1], "4");
            Assert.AreEqual(result[2], "Buzz");
            Assert.AreEqual(result[3], "FizzBuzz");
            Assert.AreEqual(result[4], "17");
            Assert.AreEqual(result[5], "29");

        }

        [Test]
        public void Test6()
        {
            AdvancedFizzBuzzConfig config = new AdvancedFizzBuzzConfig();
            config.AddParam(3, "Fizz");
            config.AddParam(11, "Buzz");
            config.AddParam(42, "Bang");

            var generator = new AdvancedFizzBuzz(config);
            var result = generator.generateFizzBuzz(Enumerable.Range(-18, 235+19).ToArray());

            Assert.AreEqual(result.Count, 235 + 19 );
            Assert.AreEqual(result[0], "Fizz");
            Assert.AreEqual(result[1], "-17");
            Assert.AreEqual(result[2], "-16");
            Assert.AreEqual(result[252], "Fizz");
            Assert.AreEqual(result[253], "235");

        }
    }
}