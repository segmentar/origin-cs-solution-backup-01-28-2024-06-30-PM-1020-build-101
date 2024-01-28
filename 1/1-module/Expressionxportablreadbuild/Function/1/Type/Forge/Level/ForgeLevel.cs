using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class ExpressionxportablereadbuildModule
    {
        public partial class XSingle
        {
            public static XSingle ForgeLevel(MemoryStream value_MEMORYSTREAM, Expressionxportablelayout value_EXPRESSIONXPORTABLELAYOUT)
            {
                XSingle xsingleResult = default;

                BinaryReader binaryReader;

                binaryReader = new BinaryReader(value_MEMORYSTREAM, Expressionxportableconfigure.ReaderEncoding, true);

                var array = FunctionLevelSetSurface(binaryReader, value_EXPRESSIONXPORTABLELAYOUT);

                XSingle xsingle;

                xsingle = new XSingle(binaryReader, array);

                xsingleResult = xsingle;

                return xsingleResult;
            }
        }
    }
}
