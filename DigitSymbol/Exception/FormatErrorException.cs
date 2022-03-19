using System;
using System.Collections.Generic;
using System.Text;

namespace DigitSymbol.Scalar.Exception
{
    /// <summary>
    /// 格式错误异常类
    /// </summary>
    public class FormatErrorException : ScalarException
    {
        public FormatErrorException()
        {
            Type = ScalarExceptionType.FormatError;
        }
    }
}
