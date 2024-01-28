using Core;

namespace Core
{
    using System;

    public partial class ExpressionxportablewritebuildModule
    {
        public partial class XQuadruple
        {
            public static ExpressionxportablewriteXlev_lY[] FunctionLevelSetSurface(ExpressionxportablewriteXle_elY[] LeveL_ARRAY)
            {
                ExpressionxportablewriteXlev_lY[] arrayResult = default;

                var list = FunctionLevelSet(LeveL_ARRAY);

                var array = new ExpressionxportablewriteXlev_lY[list.Count];

                list.CopyTo(array, ExpressionxportablePolicy.ExpressionxportableIndexPolicy);

                arrayResult = array;    

                return arrayResult;
            }
        }
    }
}
