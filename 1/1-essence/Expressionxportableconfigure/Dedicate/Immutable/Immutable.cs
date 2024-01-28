using Core;

namespace Core
{
    using System;

    using System.Text;

    public partial struct Expressionxportableconfigure
    {
        public partial class Immutable
        {
            public static Encoding WriterEncoding;

            public static Encoding ReaderEncoding;

            public static Int32 StartAddress;

            public static Int32 ChunkSize;

            static Immutable()
            {
                WriterEncoding = ExpressionxportableconfigureDefault.WriterEncodingDefault;

                ReaderEncoding = ExpressionxportableconfigureDefault.ReaderEncodingDefault;

                StartAddress = ExpressionxportableconfigureDefault.StartAddressDefault;

                ChunkSize = ExpressionxportableconfigureDefault.ChunkSizeDefault;

                return;
            }
        }
    }
}
