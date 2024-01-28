using Core;

namespace Core
{
    using System;

    public partial class Expressionxportableremoteout
    {
        public static Type RemoteType(Byte[] array_BYTE)
        {
            Type typeResult = default;

            var data = Expressionxportableconfigure.ReaderEncoding.GetString(array_BYTE);

            var result = Type.GetType(data);

            typeResult = result;

            return typeResult;
        }
    }
}
