using Core;

namespace Core
{
    using System;

    public partial class ExpressionxportablewritebuildModule
    {
        public static XSeptuple ForgeLevel(ExpressionxportablewriteU_evelV[] Level_ARRAY)
        {
            XSeptuple xseptupleResult = default;

            var array = XSeptuple.FunctionLevelSetSurface(Level_ARRAY);

            XSeptuple xseptuple;

            xseptuple = new XSeptuple(array);

            xseptupleResult = xseptuple;

            return xseptupleResult;
        }
    }
}
