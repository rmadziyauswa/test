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

        [Test]
        public void NKSubstrings_Test()
        {
            //Arrange
            var n = new NKSubstrings();
            int n1 = 120;
            int k1 = 2;
            int expected1 = 2;

            int n2 = 555;
            int k2 = 1;
            int expected2 = 1;

            int n3 = 5341;
            int k3 = 2;
            int expected3 = 0;


            //Act
            int actual1 = n.divisorSubstrings(n1, k1);
            int actual2 = n.divisorSubstrings(n2, k2);
            int actual3 = n.divisorSubstrings(n3, k3);

            //Assert
            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);
            Assert.AreEqual(expected3, actual3);
        }

        [Test]
        public void justifyNewspaperText_Test()
        {
            //Arrange
            var j = new JustifyNewspaper();
            string[][] lines = new string[][] {
                new string[] {"hello", "world" },
                new string[]{"How", "areYou", "doing" },
                new string[]{"Please look", "and align", "to right" } };
            string[] aligns = new string[] { "LEFT", "RIGHT", "RIGHT" };
            int width = 16;
            var expected = new string[] {
                "******************",
                "*hello world     *",
                "*How areYou doing*",
                "*     Please look*",
                "*       and align*",
                "*        to right*",
                "******************"
            };

            //Act
            var actual = j.justifyNewspaperText(lines, aligns, width);

            //Assert
            Assert.IsTrue(expected.SequenceEqual(actual));
        }

        [Test]
        public void RectangleOperations_Test()
        {
            //Arrange
            var r = new RectangleOperations();
            var operations1 = new int[][]
                {
                    new int[]{1,1,1}
                };
            var expected1 = new bool[] { true };

            var operations2 = new int[][]
              {
                    new int[]{0, 1, 3},
                    new int[]{0, 4, 2},
                    new int[]{1, 3, 4},
                    new int[]{ 1, 3, 2 }
              };
            var expected2 = new bool[] { true,false };



            //Act
            var actual1 = r.rectangleBoxes(operations1);
            var actual2 = r.rectangleBoxes(operations2);

            //Assert
            Assert.IsTrue(expected1.SequenceEqual(actual1));
            Assert.IsTrue(expected2.SequenceEqual(actual2));

        }

    }
}