using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitSymbol.Scalar.NumberString
{
    /// <summary>
    /// 自然数串类
    /// </summary>
    public partial class NaturalNumStr
    {
        /// <summary>
        /// 加法运算符
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static NaturalNumStr operator +(NaturalNumStr a, NaturalNumStr b)
        {
            return new NaturalNumStr(a as NumStr + b as NumStr, false);
        }
    }
}
