using Core;

namespace Core
{
    using System;

    public partial struct Expressionxportableconfigure
    {
        public static Expressionxportableconfigure Export()
        {
            Expressionxportableconfigure expressionxportableconfigureResult = default;

            Expressionxportableconfigure expressionxportableconfigure;

            expressionxportableconfigure = new Expressionxportableconfigure();

            expressionxportableconfigure.WriterEncodingObject = WriterEncoding;

            expressionxportableconfigure.ReaderEncodingObject = ReaderEncoding;

            expressionxportableconfigure.StartAddressObject = StartAddress;

            expressionxportableconfigure.ChunkSizeObject = ChunkSize;

            expressionxportableconfigureResult = expressionxportableconfigure;

            return expressionxportableconfigureResult;
        }
    }
}
