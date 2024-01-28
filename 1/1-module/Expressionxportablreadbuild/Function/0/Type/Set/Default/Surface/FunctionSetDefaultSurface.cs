using Core;

namespace Core
{
    using System;

    public partial class ExpressionxportablereadbuildModule
    {   
        public partial class XZeroth
        {
            public static Expressionxportable[] FunctionDefaultSetSurface(ExpressionxportablereadXlev_lY[] Level_ARRAY)
            {
                Expressionxportable[] arrayResult = default;

                var list = FunctionDefaultSet(Level_ARRAY);

                var array = new Expressionxportable[list.Count];

                list.CopyTo(array, ExpressionxportablePolicy.ExpressionxportableIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}
