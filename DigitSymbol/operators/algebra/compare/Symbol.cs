using DigitSymbol.Exception;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitSymbol.Algebra
{
    public partial class Symbol
    {
        public static bool operator >(Symbol a, Symbol b)
        {
            if (a.Value != null && b.Value != null)
            {
                return a.Value < b.Value;
            }
            else
            {
                throw new ShortOfArgumentsException();
            }
        }

        public static bool operator <(Symbol a, Symbol b)
        {
            if (a.Value != null && b.Value != null)
            {
                return a.Value < b.Value;
            }
            else
            {
                throw new ShortOfArgumentsException();
            }
        }

        public static bool operator ==(Symbol a, Symbol b)
        {
            if (a.Value != null && b.Value != null)
            {
                return a.Value == b.Value;
            }
            else
            {
                throw new ShortOfArgumentsException();
            }
        }

        public static bool operator !=(Symbol a, Symbol b)
        {
            if (a.Value != null && b.Value != null)
            {
                return !(a.Value == b.Value);
            }
            else
            {
                throw new ShortOfArgumentsException();
            }
        }

        public static bool operator >=(Symbol a, Symbol b)
        {
            if (a.Value != null && b.Value != null)
            {
                return a.Value > b.Value || a.Value == b.Value;
            }
            else
            {
                throw new ShortOfArgumentsException();
            }
        }

        public static bool operator <=(Symbol a, Symbol b)
        {
            if (a.Value != null && b.Value != null)
            {
                return a.Value < b.Value || a.Value == b.Value;
            }
            else
            {
                throw new ShortOfArgumentsException();
            }
        }
    }
}
