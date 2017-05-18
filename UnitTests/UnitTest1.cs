using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzzSpecialKata;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        private static FizzBuzz _sut;

        [ClassInitialize]
        public static void Init(TestContext testContext)
        {
            _sut = new FizzBuzz();
            _sut.AddRule(new Rule(3, "fizz"));
            _sut.AddRule(new Rule(5, "buzz"));
            _sut.AddRule(new Rule(7, "pop"));
            _sut.AddRule(new Rule(2, "pep"));
        }

        [TestMethod]
        public void NormalNumber_Return_SameNumber()
        {
            // ARRANGE                 

            // ACT
            string expected = "1";
            string actual = _sut.Process(1);

            // ASSERT
            Assert.IsTrue(expected.Equals(actual));
        }

        [TestMethod]
        public void NumberDivisibleBy3_Returns_Fizz()
        {
            // ARRANGE            

            // ACT
            string expected = "fizz";
            string actual = _sut.Process(3);

            // ASSERT
            Assert.IsTrue(expected.Equals(actual));
        }

        [TestMethod]
        public void NumberDivisibleBy5_Returns_Buzz()
        {
            // ARRANGE            

            // ACT
            string expected = "buzz";
            string actual = _sut.Process(5);

            // ASSERT
            Assert.IsTrue(expected.Equals(actual));
        }

        [TestMethod]
        public void NumberDivisibleBy3And5_Returns_FizzBuzz()
        {
            // ARRANGE            

            // ACT
            string expected = "fizz buzz";
            string actual = _sut.Process(15);

            // ASSERT
            Assert.IsTrue(expected.Equals(actual));
        }

        [TestMethod]
        public void NumberDivisibleBy7_Returns_Pop()
        {
            // ARRANGE            

            // ACT
            string expected = "pop pep";
            string actual = _sut.Process(14);

            // ASSERT
            Assert.IsTrue(expected.Equals(actual));
        }

        [TestMethod]
        public void NumberDivisibleBySeveralNumbers_Returns_AllEquivalentStringsNumbers()
        {
            // ARRANGE            

            // ACT
            string expected = "fizz buzz pop";
            string actual = _sut.Process(105);

            // ASSERT
            Assert.IsTrue(expected.Equals(actual));
        }
    }
}
