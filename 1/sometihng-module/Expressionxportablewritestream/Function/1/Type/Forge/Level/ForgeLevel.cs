using Core;

namespace Core
{
    using System;

    using System.IO;

    using System.Text;

    public partial class ExpressionxportablewritestreamModule
    {
        public partial class XSingle
        {
            public static XSingle ForgeLeveL(Expressionxportablelayout value_EXPRESSIONXPORTABLELAYOUT)
            {
                XSingle xsingleResult = default;

                MemoryStream memoryStream;

                memoryStream = new MemoryStream();

                BinaryWriter binaryWriter;

                binaryWriter = new BinaryWriter(memoryStream, Expressionxportableconfigure.WriterEncoding, true);

                using (binaryWriter)
                {
                    var absorb = new UInt32[3];

                    absorb[0] = Convert.ToUInt32(value_EXPRESSIONXPORTABLELAYOUT.ExpressionCount);

                    absorb[1] = Convert.ToUInt32(value_EXPRESSIONXPORTABLELAYOUT.StartAddressSubjectTable);

                    absorb[2] = Convert.ToUInt32(value_EXPRESSIONXPORTABLELAYOUT.StartAddressObjectTable);

                    binaryWriter.Write(absorb[0]);

                    binaryWriter.Write(absorb[1]);

                    binaryWriter.Write(absorb[2]);

                    binaryWriter.Close();

                    binaryWriter.Dispose();
                }

                var array = memoryStream.ToArray();

                XSingle xsingle;

                xsingle = new XSingle(memoryStream, binaryWriter, array);

                xsingleResult = xsingle;

                return xsingleResult;
            }
        }
    }
}
