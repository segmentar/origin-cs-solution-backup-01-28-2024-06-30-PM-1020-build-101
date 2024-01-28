using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class ExpressionxportablereadbuildModule
    {
        public partial class XDouble
        {
            public static ExpressionxportablereadXl_velY[] FunctionLevelSetSurface(BinaryReader value_BINARYREADER, ExpressionxportablereadX_evelY[] Level_ARRAY)
            {
                ExpressionxportablereadXl_velY[] arrayResult = default;

                var list = FunctionLevelSet(value_BINARYREADER, Level_ARRAY);

                var array = new ExpressionxportablereadXl_velY[list.Count];

                list.CopyTo(array, ExpressionxportablePolicy.ExpressionxportableIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}
