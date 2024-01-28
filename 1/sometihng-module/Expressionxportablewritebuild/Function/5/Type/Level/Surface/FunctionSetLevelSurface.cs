using Core;

namespace Core
{
    using System;

    public partial class ExpressionxportablewritebuildModule
    {
        public partial class XQuintuple
        {
            public static ExpressionxportablewriteXleve_Y[] FunctionLevelSetSurface(ExpressionxportablewriteXlev_lY[] Level_ARRAY, Expressionxportablelayout value_EXPRESSIONXPORTABLELAYOUT)
            {
                ExpressionxportablewriteXleve_Y[] arrayResult = default;

                var list = FunctionLevelSet(Level_ARRAY, value_EXPRESSIONXPORTABLELAYOUT);

                var array = new ExpressionxportablewriteXleve_Y[list.Count];

                list.CopyTo(array, ExpressionxportablePolicy.ExpressionxportableIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}
