using Core;

namespace Core
{
    using System;

    public partial class ExpressionxportablewritebuildModule
    {
        public partial class XSextuple
        {
            public static XSextuple ForgeLevel(ExpressionxportablewriteXleve_Y[] Level_ARRAY, Expressionxportablelayout value_EXPRESSIONXPORTABLELAYOUT)
            {
                XSextuple xsextupleResult = default;

                var array = FunctionLevelSetSurface(Level_ARRAY, value_EXPRESSIONXPORTABLELAYOUT);

                XSextuple xsextuple;

                xsextuple = new XSextuple(array);

                xsextupleResult = xsextuple;

                return xsextupleResult;
            }
        }
    }
}
