using Core;

namespace Core
{
    using System;

    public partial class ExpressionxportablewritebuildModule
    {
        public partial class XSingle
        {
            public static ExpressionxportablewriteX_evelY[] FunctionLevelSetSurface(Expressionxportable[] array_EXPRESSIONXPORTABLE)
            {
                ExpressionxportablewriteX_evelY[] arrayResult = default;
                
                var list = FunctionLevelSet(array_EXPRESSIONXPORTABLE);

                var array = new ExpressionxportablewriteX_evelY[list.Count];

                list.CopyTo(array, ExpressionxportablePolicy.ExpressionxportableIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}
