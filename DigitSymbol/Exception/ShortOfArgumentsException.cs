using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitSymbol.Exception
{
    /// <summary>
    /// 缺少参数异常类
    /// </summary>
    public class ShortOfArgumentsException : AlgebraException
    {
        public ShortOfArgumentsException()
        {
            Type = AlgebraExceptionType.ShortOfArguments;
        }
    }
}
