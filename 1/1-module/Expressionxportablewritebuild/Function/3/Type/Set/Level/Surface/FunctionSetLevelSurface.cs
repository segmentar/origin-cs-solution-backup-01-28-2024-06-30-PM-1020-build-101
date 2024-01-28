using Core;

namespace Core
{
    using System;

    public partial class ExpressionxportablewritebuildModule
    {
        public partial class XTriple
        {
            public static ExpressionxportablewriteXle_elY[] FunctionLevelSetSurface(ExpressionxportablewriteXl_velY[] Level_ARRAY, Expressionxportable[] array_EXPRESSIONXPORTABLE)
            {
                ExpressionxportablewriteXle_elY[] arrayResult = default;
                
                var list = FunctionLevelSet(Level_ARRAY, array_EXPRESSIONXPORTABLE);

                var array = new ExpressionxportablewriteXle_elY[list.Count];

                list.CopyTo(array, ExpressionxportablePolicy.ExpressionxportableIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}
