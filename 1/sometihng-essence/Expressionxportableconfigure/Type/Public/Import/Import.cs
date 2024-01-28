using Core;

namespace Core
{
    using System;

    using System.Text;

    public partial struct Expressionxportableconfigure
    {
        public static void Import(Expressionxportableconfigure value_EXPRESSIONXPORTABLECONFIGURE)
        {
            WriterEncoding = (Encoding)value_EXPRESSIONXPORTABLECONFIGURE.WriterEncodingObject;

            ReaderEncoding = (Encoding)value_EXPRESSIONXPORTABLECONFIGURE.ReaderEncodingObject;

            StartAddress = (Int32)value_EXPRESSIONXPORTABLECONFIGURE.StartAddressObject;

            ChunkSize = (Int32)value_EXPRESSIONXPORTABLECONFIGURE.ChunkSizeObject;

            return;
        }
    }
}
