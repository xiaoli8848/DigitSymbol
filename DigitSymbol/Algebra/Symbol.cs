using DigitSymbol.Scalar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitSymbol.Algebra
{
    public partial class Symbol
    {
        /// <summary>
        /// 代数符号的字符形式
        /// </summary>
        public char Sign { get; set; }
        /// <summary>
        /// 数值范围
        /// </summary>
        public ValueRange ValueRange { get; set; }
        /// <summary>
        /// 对应的数值
        /// </summary>
        public Digitable? Value { 
            get { return Value; } 
            set { if (!this.ValueRange.isInRange(value)) throw new ArgumentException("给定的数值超出范围。", value.ToString());   Value = value; } 
        }

        /// <summary>
        /// 构造一个代数符号，数值范围为任意数。
        /// </summary>
        /// <param name="Sign">代数符号的字符形式</param>
        public Symbol(char sign)
        {
            this.Sign = sign;
            this.ValueRange = ValueRange.ALL;
        }

        /// <summary>
        /// 构造一个给定数值范围，且预设对应数值的代数符号。
        /// </summary>
        /// <param name="sign">代数符号的字符形式</param>
        /// <param name="valueRange">数值范围</param>
        /// <param name="value">对应数值</param>
        public Symbol(char sign, ValueRange valueRange, Digitable value)
        {
            this.Sign = sign;
            this.ValueRange = valueRange;
            this.Value = value;
        }
    }
}
