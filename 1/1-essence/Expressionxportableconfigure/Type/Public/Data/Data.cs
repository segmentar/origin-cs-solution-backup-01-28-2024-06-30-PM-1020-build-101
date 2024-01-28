using Core;

namespace Core
{
    using System;

    public partial struct Expressionxportableconfigure
    {
        public static Expressionxportableconfigure Data()
        {
            Expressionxportableconfigure expressionxportableconfigureResult = default;

            Expressionxportableconfigure expressionxportableconfigure;

            expressionxportableconfigure = new Expressionxportableconfigure();

            expressionxportableconfigure.WriterEncodingObject = Immutable.WriterEncoding;

            expressionxportableconfigure.ReaderEncodingObject = Immutable.ReaderEncoding;

            expressionxportableconfigure.StartAddressObject = Immutable.StartAddress;

            expressionxportableconfigure.ChunkSizeObject = Immutable.ChunkSize;

            expressionxportableconfigureResult = expressionxportableconfigure;

            return expressionxportableconfigureResult;
        }
    }
}
