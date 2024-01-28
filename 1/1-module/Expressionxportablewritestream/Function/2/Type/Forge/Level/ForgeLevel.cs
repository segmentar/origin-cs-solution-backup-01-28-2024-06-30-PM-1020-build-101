using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class ExpressionxportablewritestreamModule
    {
        public partial class XDouble
        {
            public static XDouble ForgeLevel(ExpressionxportablewritebuildPort value_MATERIALXPORTABLEWRITEBUILDPORT)
            {
                XDouble xdoubleResult = default;

                MemoryStream memoryStream;

                memoryStream = new MemoryStream();

                BinaryWriter binaryWriter;

                binaryWriter = new BinaryWriter(memoryStream, Expressionxportableconfigure.WriterEncoding, true);

                using (binaryWriter)
                {
                    var index = 0;

                    foreach (ExpressionxportablewriteUl_velV Level_VALUE in value_MATERIALXPORTABLEWRITEBUILDPORT.LevelLevelLevelLevelLevelLevelLevel)
                    {
                        binaryWriter.BaseStream.Seek(index, SeekOrigin.Begin);

                        var absorb = new UInt32[7];

                        absorb[0] = Convert.ToUInt32(Level_VALUE.Ordinal);

                        absorb[1] = Convert.ToUInt32(Level_VALUE.Layer);

                        absorb[2] = Convert.ToUInt32(Level_VALUE.Relate);

                        absorb[3] = Convert.ToUInt32(Level_VALUE.ObjectStartAddress);

                        absorb[4] = Convert.ToUInt32(Level_VALUE.ObjectEndAddress);

                        absorb[5] = Convert.ToUInt32(Level_VALUE.TypeStartAddress);

                        absorb[6] = Convert.ToUInt32(Level_VALUE.TypeEndAddress);

                        binaryWriter.Write(absorb[0]);

                        binaryWriter.Write(absorb[1]);

                        binaryWriter.Write(absorb[2]);

                        binaryWriter.Write(absorb[3]);

                        binaryWriter.Write(absorb[4]);

                        binaryWriter.Write(absorb[5]);

                        binaryWriter.Write(absorb[6]);

                        binaryWriter.Write(Level_VALUE.Identity);

                        index = index + Expressionxportableconfigure.ChunkSize;

                        continue;
                    }

                    binaryWriter.Close();

                    binaryWriter.Dispose();
                }

                var array = memoryStream.ToArray();

                XDouble xdouble;

                xdouble = new XDouble(memoryStream, binaryWriter, array);

                xdoubleResult = xdouble;

                return xdoubleResult;
            }
        }
    }
}
