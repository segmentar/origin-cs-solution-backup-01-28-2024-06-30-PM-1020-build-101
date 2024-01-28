using Core;

namespace Core
{
    using System;

    public partial class Expressionxportableremoteout
    {
        public static Object GroupBoolean(Byte[] Remote_ARRAY)
        {
            Object objectResult = default;

            var result = BitConverter.ToBoolean(Remote_ARRAY, ExpressionxportablePolicy.ExpressionxportableIndexPolicy);

            objectResult = result;

            return objectResult;
        }
    }
}
