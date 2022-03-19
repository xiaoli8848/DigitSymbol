using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitSymbol.Exception
{
    /// <summary>
    /// 错误类型枚举
    /// </summary>
    public enum AlgebraExceptionType
    {
        /// <summary>
        /// 其它
        /// </summary>
        Other,
        /// <summary>
        /// 参数不足
        /// </summary>
        ShortOfArguments
    }

    public abstract class AlgebraException : System.Exception
    {
        public AlgebraExceptionType Type { get; protected set; } = AlgebraExceptionType.Other;
    }
}
