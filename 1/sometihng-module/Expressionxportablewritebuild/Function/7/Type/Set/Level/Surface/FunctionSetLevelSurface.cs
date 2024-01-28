using Core;

namespace Core
{
    using System;

    public partial class ExpressionxportablewritebuildModule
    {
        public partial class XSeptuple
        {
            public static ExpressionxportablewriteUl_velV[] FunctionLevelSetSurface(ExpressionxportablewriteU_evelV[] Level_ARRAY)
            {
                ExpressionxportablewriteUl_velV[] arrayResult = default;

                var list = FunctionLevelSet(Level_ARRAY);

                var array = new ExpressionxportablewriteUl_velV[list.Count];

                list.CopyTo(array, ExpressionxportablePolicy.ExpressionxportableIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}
