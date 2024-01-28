using Core;

namespace Core
{
    using System;

    public partial class ExpressionxportablereadbuildModule
    {
        public static ExpressionxportablereadXlev_lY[] FunctionLevelSetSurface(ExpressionxportablereadXle_elY[] Level_ARRAY)
        {
            ExpressionxportablereadXlev_lY[] arrayResult = default;

            var list = FunctionLevelSet(Level_ARRAY);

            var array = new ExpressionxportablereadXlev_lY[list.Count];

            list.CopyTo(array, ExpressionxportablePolicy.ExpressionxportableIndexPolicy);

            arrayResult = array;

            return arrayResult;
        }
    }
}
