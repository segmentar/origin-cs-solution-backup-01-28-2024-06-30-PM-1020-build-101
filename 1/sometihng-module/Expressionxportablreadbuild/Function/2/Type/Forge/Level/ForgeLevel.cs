using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class ExpressionxportablereadbuildModule
    {
        public partial class XDouble
        {
            public static XDouble ForgeLevel(MemoryStream value_MEMORYSTREAM, ExpressionxportablereadX_evelY[] Level_ARRAY)
            {
                BinaryReader binaryReader;

                binaryReader = new BinaryReader(value_MEMORYSTREAM, Expressionxportableconfigure.ReaderEncoding, ExpressionxportablePolicy.ExpressionxportableStreamPolicy);

                var array = FunctionLevelSetSurface(binaryReader, Level_ARRAY);

                XDouble xdoubleResult = default;

                XDouble xdouble;

                xdouble = new XDouble(array);

                xdoubleResult = xdouble;

                return xdoubleResult;
            }
        }
    }
}
