using Core;

namespace Core
{
    using System;

    public partial class Expressionxportableremoteout
    {
        public static Object GroupUInt64(Byte[] Remote_ARRAY)
        {
            Object objectResult = default;

            var result = BitConverter.ToUInt64(Remote_ARRAY, ExpressionxportablePolicy.ExpressionxportableIndexPolicy);

            objectResult = result;

            return objectResult;
        }
    }
}
