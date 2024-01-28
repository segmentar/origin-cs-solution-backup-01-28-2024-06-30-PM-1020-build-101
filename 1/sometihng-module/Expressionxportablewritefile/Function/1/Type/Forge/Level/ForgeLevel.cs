using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class ExpressionxportablewritefileModule
    {
        public static XSingle ForgeLevel(String Path_VALUE, Expressionxportablelayout value_EXPRESSIONXPORTABLELAYOUT, ExpressionxportablewritestreamPort value_EXPRESSIONXPORTABLEWRITESTREAMPORT)
        {
            XSingle xsingleResult = default;

            if (File.Exists(Path_VALUE) is true)
            {
                File.Delete(Path_VALUE);
            }
            else
                "false".ToString();

            FileStream fileStream;

            fileStream = File.Create(Path_VALUE);

            MemoryStream memoryStream;

            memoryStream = new MemoryStream();

            BinaryWriter binaryWriter;

            binaryWriter = new BinaryWriter(memoryStream, Expressionxportableconfigure.WriterEncoding, true);

            using (binaryWriter)
            {
                binaryWriter.Write(value_EXPRESSIONXPORTABLEWRITESTREAMPORT.HeaderTableByteArray);

                binaryWriter.BaseStream.Seek(value_EXPRESSIONXPORTABLELAYOUT.StartAddressSubjectTable, SeekOrigin.Begin);

                binaryWriter.Write(value_EXPRESSIONXPORTABLEWRITESTREAMPORT.SubjectTableByteArray);

                binaryWriter.BaseStream.Seek(value_EXPRESSIONXPORTABLELAYOUT.StartAddressObjectTable, SeekOrigin.Begin);

                binaryWriter.Write(value_EXPRESSIONXPORTABLEWRITESTREAMPORT.ObjectTableByteArray);

                binaryWriter.Close();

                binaryWriter.Dispose();
            }

            memoryStream.Position = 0;

            memoryStream.CopyTo(fileStream);

            XSingle xsingle;

            xsingle = new XSingle(fileStream, memoryStream, binaryWriter);

            xsingleResult = xsingle;

            return xsingleResult;
        }
    }
}
