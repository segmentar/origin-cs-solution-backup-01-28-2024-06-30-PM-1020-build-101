using Core;

namespace Core
{
    using System;

    public partial struct Expressionxportablereadclose
    {
        public static void Close(Expressionxportablereadclose value_EXPRESSIONXPORTABLEREADCLOSE, Object[] array_OBJECT)
        {
            if (value_EXPRESSIONXPORTABLEREADCLOSE.FileStreamCloseShould is true)
            {
                using (var stream = ((ExpressionxportablereadfileModule)array_OBJECT[0]).ExpressionxportablereadfilePort.FileStream)
                {
                    stream.Close();

                    stream.Dispose();
                }
            }
            else
                "false".ToString();

            if (value_EXPRESSIONXPORTABLEREADCLOSE.MemoryStreamCloseShould is true)
            {
                using (var stream = ((ExpressionxportablereadfileModule)array_OBJECT[0]).ExpressionxportablereadfilePort.MemoryStream)
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
