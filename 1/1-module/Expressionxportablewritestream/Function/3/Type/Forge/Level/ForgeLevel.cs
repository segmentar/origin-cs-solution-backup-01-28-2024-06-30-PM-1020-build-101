using Core;

namespace Core
{
    using System;

    using System.IO;

    using System.Text;

    public partial class ExpressionxportablewritestreamModule
    {
        public partial class XTriple
        {
            public static XTriple ForgeLeveL(ExpressionxportablewriteUl_velV[] Level_ARRAY)
            {
                XTriple xtripleResult = default;

                MemoryStream memoryStream;

                memoryStream = new MemoryStream();

                BinaryWriter binaryWriter;

                binaryWriter = new BinaryWriter(memoryStream, Expressionxportableconfigure.WriterEncoding, true);

                using (binaryWriter)
                {
                    foreach (ExpressionxportablewriteUl_velV Level_VALUE in Level_ARRAY)
                    {
                        binaryWriter.Write(Level_VALUE.ObjectByteArray);

                        binaryWriter.Write(Level_VALUE.TypeByteArray);

                        continue;
                    }

                    binaryWriter.Close();

                    binaryWriter.Dispose();
                }

                var array = memoryStream.ToArray();

                XTriple xtriple;

                xtriple = new XTriple(memoryStream, binaryWriter, array);

                xtripleResult = xtriple;

                return xtripleResult;
            }
        }
    }
}
