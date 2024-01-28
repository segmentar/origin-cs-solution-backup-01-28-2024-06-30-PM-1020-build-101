using Core;

namespace Core
{
    using System;

    public partial class ExpressionxportablereadbuildModule
    {
        public partial class XZeroth
        {
            public static Expressionxportable Default(ExpressionxportablereadXlev_lY[] Level_ARRAY)
            {
                Expressionxportable expressionxportableResult = default;

                foreach (ExpressionxportablereadXlev_lY Level_VALUE in Level_ARRAY)
                {
                    var boolean = true;

                    boolean = boolean && Object.Equals(Level_VALUE.Ordinal, 1) is true;

                    boolean = boolean && Object.Equals(Level_VALUE.Layer, 1) is true;

                    boolean = boolean && Object.Equals(Level_VALUE.Relate, 0) is true;

                    Boolean isEqualCheck, shouldContinueCheck;

                    isEqualCheck = boolean is true;

                    shouldContinueCheck = isEqualCheck is false;

                    if (shouldContinueCheck is true)
                    {
                        continue;
                    }
                    else
                        "false".ToString();

                    var result = Level_VALUE.Expressionxportable;

                    expressionxportableResult = result;

                    break;
                }

                return expressionxportableResult;
            }
        }
    }
}
