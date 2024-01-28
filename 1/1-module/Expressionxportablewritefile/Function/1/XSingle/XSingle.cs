using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class ExpressionxportablewritefileModule
    {
        [Expressionxportableisc]
        public partial class XSingle
        {
            public FileStream FileStream;

            public MemoryStream MemoryStream;

            public BinaryWriter BinaryWriter;

            public XSingle(FileStream fileStream, MemoryStream memoryStream, BinaryWriter binaryWriter)
            {
                this.FileStream = fileStream;

                this.MemoryStream = memoryStream;

                this.BinaryWriter = binaryWriter;

                return;
            }

            ~XSingle()
            {
                return;
            }

            [Expressionxportableism]
            public override String ToString()
            {
                return String.Join('\n'.ToString(), new String[] {

                    String.Empty + nameof(XSingle) + ' ' + "::" + ' ' + '{',
                    String.Empty + '.' + "function",
                    String.Empty + '\t' + '~' + "01" + ' ' + nameof(FileStream) + ':' + ' ' + ". . .",
                    String.Empty + '\t' + '~' + "02" + ' ' + nameof(MemoryStream) + ':' + ' ' + ". . .",
                    String.Empty + '\t' + '~' + "03" + ' ' + nameof(BinaryWriter) + ':' + ' ' + ". . .",
                    String.Empty + '}',
                    String.Empty,
                    String.Empty + '~' + "10" + ' ' + nameof(FileStream) + ':',
                    String.Empty + FileStream,
                    String.Empty,
                    String.Empty + '~' + "20" + ' ' + nameof(MemoryStream) + ':',
                    String.Empty + MemoryStream,
                    String.Empty,
                    String.Empty + '~' + "30" + ' ' + nameof(BinaryWriter) + ':',
                    String.Empty + BinaryWriter
                });
            }
        }
    }
}
