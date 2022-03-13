using NaturplayMath.Algebra.Scalar;
using NaturplayMath.Algebra.Scalar.NumberString;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitSymbol.Algebra
{
    public class ValueRange
    {
        public static ValueRange ALL = new ValueRange((num) => { return true; });
        public static ValueRange ALL_REALNUM = new ValueRange((num) => { return num is RealNum; });
        public static ValueRange ALL_IRRATIONAL = new ValueRange((num) => { return num is IrrationalNum; });
        public static ValueRange ALL_RATIONAL = new ValueRange((num) => { return num is RationalNum; });
        public static ValueRange ALL_NATURALNUM = new ValueRange((num) => { return num is NaturalNumStr || num is IntegerNum && num >= new IntegerNum(); });

        private Func<Digitable, bool> Gudge;

        public bool isInRange(Digitable num)
        {
            return Gudge(num);
        }

        public ValueRange(Func<Digitable, bool> gudge)
        {
            this.Gudge = gudge;
        }

        public static ValueRange FromRealNumRange(Digitable min, Digitable max)
        {
            if(max > min)
            {
                throw new ArgumentException("限定的数值范围无效。", "[" + min.ToString() + "," + max.ToString() + "]");
            }
            return new ValueRange((num) => { return num >= min && num <= max; });
        }
    }
}
