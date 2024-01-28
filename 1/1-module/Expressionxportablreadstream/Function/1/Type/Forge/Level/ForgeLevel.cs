using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class ExpressionxportablereadstreamModule
    {
        public partial class XSingle
        {
            public static XSingle ForgeLevel(MemoryStream value_MEMORYSTREAM)
            {
                XSingle xsingleResult = default;

                BinaryReader binaryReader;

                binaryReader = new BinaryReader(value_MEMORYSTREAM, Expressionxportableconfigure.ReaderEncoding, ExpressionxportablePolicy.ExpressionxportableStreamPolicy);

                Expressionxportablelayout expressionxportablelayout;

                expressionxportablelayout = new Expressionxportablelayout();

                using (binaryReader)
                {
                    var absorb = new Int32[3];

                    absorb[0] = Convert.ToInt32(binaryReader.ReadUInt32());

                    absorb[1] = Convert.ToInt32(binaryReader.ReadUInt32());

                    absorb[2] = Convert.ToInt32(binaryReader.ReadUInt32());

                    expressionxportablelayout.ExpressionCount = absorb[0];

                    expressionxportablelayout.StartAddressSubjectTable = absorb[1];

                    expressionxportablelayout.StartAddressObjectTable = absorb[2];

                    binaryReader.Close();

                    binaryReader.Dispose();
                }

                XSingle xsingle;

                xsingle = new XSingle(binaryReader, expressionxportablelayout);

                xsingleResult = xsingle;

                return xsingleResult;
            }
        }
    }
}
