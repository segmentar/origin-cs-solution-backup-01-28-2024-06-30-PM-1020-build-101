using Core;

namespace Core
{
    using System;

    public partial class ExpressionxportablewritebuildModule
    {
        public partial class XTriple
        {
            public static XTriple ForgeLevel(ExpressionxportablewriteXl_velY[] Level_ARRAY, Expressionxportable[] array_EXPRESSIONXPORTABLE)
            {
                XTriple xtripleResult = default;

                var array = FunctionLevelSetSurface(Level_ARRAY, array_EXPRESSIONXPORTABLE);

                XTriple xtriple;

                xtriple = new XTriple(array);

                xtripleResult = xtriple;

                return xtripleResult;
            }
        }
    }
}
