using Core;

namespace Core
{
    using System;

    public partial class Expressionxportableremoteout
    {
        public static Object GroupInt32(Byte[] Remote_ARRAY)
        {
            Object objectResult = default;

            var result = BitConverter.ToInt32(Remote_ARRAY, ExpressionxportablePolicy.ExpressionxportableIndexPolicy);

            objectResult = result;

            return objectResult;
        }
    }
}
