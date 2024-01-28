using Core;

namespace Core
{
    using System;

    public partial class ExpressionxportablewritebuildModule
    {
        public partial class XSextuple
        {
            public static ExpressionxportablewriteU_evelV[] FunctionLevelSetSurface(ExpressionxportablewriteXleve_Y[] Level_ARRAY, Expressionxportablelayout value_EXPRESSIONXPORTABLELAYOUT)
            {
                ExpressionxportablewriteU_evelV[] arrayResult = default;

                var list = FunctionLevelSet(Level_ARRAY, value_EXPRESSIONXPORTABLELAYOUT);

                var array = new ExpressionxportablewriteU_evelV[list.Count];

                list.CopyTo(array, ExpressionxportablePolicy.ExpressionxportableIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}
