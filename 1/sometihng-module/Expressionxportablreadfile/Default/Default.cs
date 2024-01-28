using Core;

namespace Core
{
    using System;

    public partial class ExpressionxportablereadfileModule
    {
        public static ExpressionxportablereadfileModule Default(String Filename_VALUE)
        {
            ExpressionxportablereadfileModule module;

            module = new ExpressionxportablereadfileModule();

            var inflect = new Object[1];

            inflect[0] = Filename_VALUE;

            XZeroth xzeroth;

            xzeroth = new XZeroth(inflect);

            ExpressionxportablreadfileCycle.XZeroth = xzeroth;

            module.XOne();

            ExpressionxportablereadfilePort expressionxportablereadfilePort;

            expressionxportablereadfilePort = new ExpressionxportablereadfilePort();

            expressionxportablereadfilePort.FileStream = ExpressionxportablreadfileCycle.XPrimary.XSingle.FileStream;

            expressionxportablereadfilePort.MemoryStream = ExpressionxportablreadfileCycle.XPrimary.XSingle.MemoryStream;

            module.ExpressionxportablereadfilePort = expressionxportablereadfilePort;

            return module;
        }
    }
}
