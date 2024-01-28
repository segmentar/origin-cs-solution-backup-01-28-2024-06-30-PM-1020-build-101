using Core;

namespace Core
{
    using System;

    using System.Text;

    public partial class Expressionxportableremoteout
    {
        public static Object GroupString(Byte[] Remote_ARRAY)
        {
            Object objectResult = default;

            var data = Expressionxportableconfigure.ReaderEncoding.GetString(Remote_ARRAY);

            objectResult = data;

            return objectResult;
        }
    }
}
