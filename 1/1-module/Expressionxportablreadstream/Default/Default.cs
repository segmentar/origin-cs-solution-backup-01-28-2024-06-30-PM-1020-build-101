using Core;

namespace Core
{
    using System;

    public partial class ExpressionxportablereadstreamModule
    {
        public static ExpressionxportablereadstreamModule Default(String Filename_VALUE, ExpressionxportablereadfilePort value_EXPRESSIONXPORTABLEREADFILEPORT)
        {
            ExpressionxportablereadstreamModule module;

            module = new ExpressionxportablereadstreamModule();

            var inflect = new Object[2];

            inflect[0] = Filename_VALUE;

            inflect[1] = value_EXPRESSIONXPORTABLEREADFILEPORT;

            XZeroth xzeroth;

            xzeroth = new XZeroth(inflect);

            ExpressionxportablreadstreamCycle.XZeroth = xzeroth;

            module.XOne();

            ExpressionxportablereadstreamPort expressionxportablereadstreamPort;

            expressionxportablereadstreamPort = new ExpressionxportablereadstreamPort();

            expressionxportablereadstreamPort.Expressionxportablelayout = ExpressionxportablreadstreamCycle.XPrimary.XSingle.Expressionxportablelayout;

            module.ExpressionxportablereadstreamPort = expressionxportablereadstreamPort;

            return module;
        }
    }
}
