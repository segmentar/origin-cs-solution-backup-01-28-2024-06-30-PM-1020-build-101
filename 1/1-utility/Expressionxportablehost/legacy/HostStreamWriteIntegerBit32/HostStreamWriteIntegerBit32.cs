using Core;

namespace Core
{
    using System;

    using System.IO;

    using System.Text;

    public partial class Expressionxportablehost
    {
        public static void HostStreamWriteIntegerBit32(String value, String[] array)
        {
            try
            {
               /* Boolean isEqualCheck, shouldReturnCheck;

                isEqualCheck = Object.Equals(ExpressionName.EntityLibraryHostStreamWriteIntegerBit32, value) is true;

                shouldReturnCheck = isEqualCheck is false;

                if (shouldReturnCheck is true)
                {
                    return;
                }
                else
                    "false".ToString();

                var first = array[0];

                var First_VALUE = new IntegerxSimple(first).Result;

                var First_RESULT = Integerxhost.UInt32(First_VALUE);

                BinaryWriter binaryWriter;

                binaryWriter = new BinaryWriter((FileStream)Expression.FileStreamObject, (Encoding)Expression.FileStreamWriterEncoding, true);

                using (binaryWriter)
                {
                    binaryWriter.Write(First_RESULT);

                    binaryWriter.Close();

                    binaryWriter.Dispose();
                }*/
            }
            catch (Exception exception)
            {
                Interopfatal.Render($"{ExpressionCode.RenderPath.Core_Expression_Fatal}", new Expressionfatal.HostStreamWriteIntegerBit32().Initialize(new String[0], exception));
            }

            return;
        }
    }
}
