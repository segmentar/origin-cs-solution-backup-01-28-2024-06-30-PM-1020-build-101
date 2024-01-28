using Core;

namespace Core
{
    using System;

    public partial struct Expressionxportablewriteclose
    {
        public static void Close(Expressionxportablewriteclose value_EXPRESSIONXPORTABLEWRITECLOSE, Object[] array_OBJECT)
        {
            if (value_EXPRESSIONXPORTABLEWRITECLOSE.FlushShould is true)
            {
                ((ExpressionxportablewritefileModule)array_OBJECT[2]).ExpressionxportablewritefilePort.FileStream.Flush();
            }
            else
                "false".ToString();

            if (value_EXPRESSIONXPORTABLEWRITECLOSE.FileStreamCloseShould is true)
            {
                using (var stream = ((ExpressionxportablewritefileModule)array_OBJECT[2]).ExpressionxportablewritefilePort.FileStream)
                {
                    stream.Close();

                    stream.Dispose();
                }
            }
            else
                "false".ToString();

            if (value_EXPRESSIONXPORTABLEWRITECLOSE.MemoryStreamCloseShould is true)
            {
                using (var stream = ((ExpressionxportablewritefileModule)array_OBJECT[2]).ExpressionxportablewritefilePort.MemoryStream)
                {
                    stream.Close();

                    stream.Dispose();
                }
            }
            else
                "false".ToString();

            if (value_EXPRESSIONXPORTABLEWRITECLOSE.HeaderTableMemoryStreamCloseShould is true)
            {
                using (var stream = ((ExpressionxportablewritestreamModule)array_OBJECT[1]).ExpressionxportablewritestreamPort.HeaderTableMemoryStream)
                {
                    stream.Close();

                    stream.Dispose();
                }
            }
            else
                "false".ToString();

            if (value_EXPRESSIONXPORTABLEWRITECLOSE.SubjectTableMemoryStreamCloseShould is true)
            {
                using (var stream = ((ExpressionxportablewritestreamModule)array_OBJECT[1]).ExpressionxportablewritestreamPort.SubjectTableMemoryStream)
                {
                    stream.Close();

                    stream.Dispose();
                }
            }
            else
                "false".ToString();

            if (value_EXPRESSIONXPORTABLEWRITECLOSE.ObjectTableMemoryStreamCloseShould)
            {
                using (var stream = ((ExpressionxportablewritestreamModule)array_OBJECT[1]).ExpressionxportablewritestreamPort.ObjectTableMemoryStream)
                {
                    stream.Close();

                    stream.Dispose();
                }
            }
            else
                "false".ToString();

            return;
        }
    }
}
