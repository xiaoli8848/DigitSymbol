using Microsoft.VisualStudio.TestTools.UnitTesting;
using DigitSymbol.Algebra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NaturplayMath.Algebra.Scalar;

namespace DigitSymbol.Algebra.Tests
{
    [TestClass()]
    public class ValueRangeTests
    {
        [TestMethod()]
        public void ValueRangeTest()
        {
            Assert.IsTrue(ValueRange.ALL.isInRange(new IntegerNum()));
            Assert.IsTrue(!ValueRange.ALL_IRRATIONAL.isInRange(new IntegerNum()));
            Assert.IsTrue(ValueRange.ALL_REALNUM.isInRange(new IntegerNum()));
            Assert.IsTrue(ValueRange.ALL_NATURALNUM.isInRange(new IntegerNum()));
            Assert.IsTrue(!ValueRange.ALL_NATURALNUM.isInRange(new IntegerNum(-1)));
            Assert.IsTrue(!ValueRange.ALL_NATURALNUM.isInRange(new IntegerNum(-1.5)));
        }
    }
}