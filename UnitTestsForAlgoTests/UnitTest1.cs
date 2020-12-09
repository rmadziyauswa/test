using AlgoTestsInterview;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;

namespace UnitTestsForAlgoTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void PythagoreanTripple_Test()
        {
            //Arrange
            var p = new PythagoreanTripple();
            var a = new int[] { 0, 5, 5, 0, 5, 13, 12 };
            var expectedAnswer = new int[] { 1, 1, 1, 0, 1 };

            //Act
            var actualAnswer = p.tripleSquareSum(a);

            //Assert
            Assert.IsTrue(expectedAnswer.SequenceEqual(actualAnswer));
        }
    }
}