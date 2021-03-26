using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IffyLib.Extensions;
using NUnit.Framework;

namespace IffyLib.Test.Extensions
{
    [TestFixture]
    public class NumberExtensions
    {
        [TestCase(1, ExpectedResult = false, TestName = "One")]
        [TestCase(2, ExpectedResult = true, TestName = "Two")]
        [TestCase(-1, ExpectedResult = false, TestName = "Minus one")]
        [TestCase(-2, ExpectedResult = true, TestName = "Minus two")]
        [TestCase(0, ExpectedResult = true, TestName = "Zero")]
        [TestCase(42, ExpectedResult = true, TestName = "Forty-two")]
        [TestCase(99999, ExpectedResult = false, TestName = "Ninety thousand nine hundred ninety nine")]
        [TestCase(int.MaxValue, ExpectedResult = false, TestName = "Really big uneven number!!")]
        [TestCase(int.MaxValue - 1, ExpectedResult = false, TestName = "Really big even number!!")]
        public bool IsEven(int value)
        {
            return value.IsEven();
        }
        
    }
}
