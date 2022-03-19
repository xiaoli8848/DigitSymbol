﻿using DigitSymbol.Scalar.Exception;
using DigitSymbol.Scalar.NumberString;
using System;
using System.Collections.Generic;
using System.Text;

namespace DigitSymbol.Scalar
{
    /// <summary>
    /// 有理数类
    /// </summary>
    public partial class RationalNum
    {
        /// <summary>
        /// 乘法运算符
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static RationalNum operator *(RationalNum a, RationalNum b) => ((a as Digitable) * (b as Digitable)) as RationalNum;

        /// <summary>
        /// 按位乘法运算（不考虑正负号）
        /// </summary>
        /// <param name="num">乘数</param>
        /// <param name="maxDecimalPlaces">答案保留小数位数</param>
        /// <returns></returns>
        protected override Digitable Multiply_unsigned(Digitable num, int maxDecimalPlaces)
        {
            RationalNum a = this, b = num as RationalNum;

            if (a == null || b == null)
                throw new ProgramInterruptException(ProgramInterruptExceptionType.IllegalValue);
            //统一计算空间
            if (a.Space != b.Space)
            {
                if (a.Space == OperationSpace.DefaultSpace)
                    a = (RationalNum)a.ChangeOperationSpace(b.Space);
                else if (b.Space == OperationSpace.DefaultSpace)
                    b = (RationalNum)b.ChangeOperationSpace(a.Space);
                else
                    throw new ProgramInterruptException(ProgramInterruptExceptionType.NotSameOperationSpace);
            }
            return new RationalNum(a.numerator * b.numerator, a.denominator * b.denominator, 1, a.Space, maxDecimalPlaces);
        }
    }
}
