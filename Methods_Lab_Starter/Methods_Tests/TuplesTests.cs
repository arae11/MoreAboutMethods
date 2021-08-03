using NUnit.Framework;
using Methods_Lib;
using System;

namespace Methods_Tests
{
    public class TuplesTests
    {
        [TestCase(25, 3, 4)]
        [TestCase(0, 0, 0)]
        [TestCase(33, 4, 5)]
        public void GivenANumber_DaysAndWeeks_ReturnsCorrectTuple(
            int totalDays, int expectedWeeks, int expectedDays)
        {
            var answer = Methods.DaysAndWeeks(totalDays);
            Assert.That(answer.weeks, Is.EqualTo(expectedWeeks), "Weeks");
            Assert.That(answer.days, Is.EqualTo(expectedDays), "Days");
        }
        [Test]
        public void GivenANegativeNumber_DaysAndWeeks_ThrowsAnException()
        {
            Assert.That(() => Methods.DaysAndWeeks(-1), Throws.TypeOf<ArgumentOutOfRangeException>()
        .With.Message.Contain("totalDays must not be negative"));
        }

        [TestCase(9, 81, 729, 3)]
        public void GivenANumber_PowersRoot_ReturnsExpected(int num, int expectedSquare, int expectedCube, double expectedRoot)
        {
            var answer = Methods.PowersRoot(num);
            Assert.That(answer.square, Is.EqualTo(expectedSquare), "Square");
            Assert.That(answer.cube, Is.EqualTo(expectedCube), "Cube");
            Assert.That(answer.root, Is.EqualTo(expectedRoot), "Root");
        }
    }
}