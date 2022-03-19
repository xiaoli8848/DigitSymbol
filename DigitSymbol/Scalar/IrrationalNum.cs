using System;
using System.Collections.Generic;
using System.Text;

namespace DigitSymbol.Scalar
{
    /// <summary>
    /// 无理数类
    /// </summary>
    public class IrrationalNum : RealNum
    {
        public override bool IsOne => throw new NotImplementedException();

        public override bool IsInteger => throw new NotImplementedException();

        public override bool IsEven => throw new NotImplementedException();

        public override bool IsOdd => throw new NotImplementedException();

        public override IOperationSpaceElement ChangeOperationSpace(OperationSpace space = null, bool? newInstance = null, int? maxDecimalPlaces = null)
        {
            throw new NotImplementedException();
        }

        public override Digitable Copy()
        {
            throw new NotImplementedException();
        }

        public override string GetDigitSymbolExp()
        {
            throw new NotImplementedException();
        }

        public override string GetTeXCode()
        {
            throw new NotImplementedException();
        }
    }
}
