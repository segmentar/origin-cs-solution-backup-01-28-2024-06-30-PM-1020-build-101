using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class ExpressionxportablereadbuildModule
    {
        public partial class XSingle
        {
            public static ExpressionxportablereadX_evelY[] FunctionLevelSetSurface(BinaryReader value_BINARYREADER, Expressionxportablelayout value_EXPRESSIONXPORTABLELAYOUT)
            {
                ExpressionxportablereadX_evelY[] arrayResult = default;

                var list = FunctionLevelSet(value_BINARYREADER, value_EXPRESSIONXPORTABLELAYOUT);

                var array = new ExpressionxportablereadX_evelY[list.Count];

                list.CopyTo(array, ExpressionxportablePolicy.ExpressionxportableIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}
