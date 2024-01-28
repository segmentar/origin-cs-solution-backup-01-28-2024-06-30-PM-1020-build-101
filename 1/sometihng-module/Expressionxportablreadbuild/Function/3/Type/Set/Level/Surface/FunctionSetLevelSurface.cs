using Core;

namespace Core
{
    using System;

    public partial class ExpressionxportablereadbuildModule
    {
        public partial class XTriple
        {
            public static ExpressionxportablereadXle_elY[] FunctionLevelSetSurface(ExpressionxportablereadXl_velY[] Level_ARRAY)
            {
                ExpressionxportablereadXle_elY[] arrayResult = default;

                var list = FunctionLevelSet(Level_ARRAY);

                var array = new ExpressionxportablereadXle_elY[list.Count];

                list.CopyTo(array, ExpressionxportablePolicy.ExpressionxportableIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}
