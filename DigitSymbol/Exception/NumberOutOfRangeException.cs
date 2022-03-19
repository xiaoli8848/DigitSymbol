using System;
using System.Collections.Generic;
using System.Text;

namespace DigitSymbol.Scalar.Exception
{
    /// <summary>
    /// 数字超出范围异常类
    /// </summary>
    public class NumberOutOfRangeException : ScalarException
    {
        public NumberOutOfRangeException()
        {
            Type = ScalarExceptionType.NumberOutOfRange;
        }
    }
}
