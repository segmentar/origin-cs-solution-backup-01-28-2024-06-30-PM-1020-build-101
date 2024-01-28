using Core;

namespace Core
{
    using System;

    public partial class Expressionxportableremoteout
    {
        public static Object GroupUInt32(Byte[] Remote_ARRAY)
        {
            Object objectResult = default;

            var result = BitConverter.ToUInt32(Remote_ARRAY, ExpressionxportablePolicy.ExpressionxportableIndexPolicy);

            objectResult = result;

            return objectResult;
        }
    }
}
