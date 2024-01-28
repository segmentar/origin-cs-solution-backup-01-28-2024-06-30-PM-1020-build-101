using Core;

namespace Core
{
    using System;

    public partial class ExpressionxportablewritebuildModule
    {
        public partial class XDouble
        {
            public static ExpressionxportablewriteXl_velY[] FunctionLevelSetSurface(ExpressionxportablewriteX_evelY[] Level_ARRAY)
            {
                ExpressionxportablewriteXl_velY[] arrayResult = default;

                var list = FunctionLevelSet(Level_ARRAY);

                var array = new ExpressionxportablewriteXl_velY[list.Count];

                list.CopyTo(array, ExpressionxportablePolicy.ExpressionxportableIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}
