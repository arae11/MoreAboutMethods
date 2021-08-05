using NUnit.Framework;
using System;
using Methods_Lib;

namespace Methods_Tests
{
    public class DiceTests
    {
        [TestCase(86, 10)]
        [TestCase(140, 7)]
        public void DiceReturn_TheSum_FromRandom(int seed, int expResult)
        {
            var rng = new Random(seed);
            var result = Methods.RollDice(rng);

            Assert.That(result, Is.EqualTo(expResult));
        }
    }
}
