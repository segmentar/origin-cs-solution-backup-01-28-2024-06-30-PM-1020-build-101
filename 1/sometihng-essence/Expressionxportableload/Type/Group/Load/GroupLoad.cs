using Core;

namespace Core
{
    using System;

    public partial class Expressionxportableload
    {
        public static Object[] GroupLoad(Expressionxportableloadcontext value_EXPRESSIONXPORTABLELOADCONTEXT, Expressionxportablereadclose value_EXPRESSIONXPORTABLEREADCLOSE, String Filename_VALUE)
        {
            Object[] arrayResult = default;

            ExpressionxportablereadfileModule expressionxportablreadfileModule = ExpressionxportablereadfileModule.Action(Filename_VALUE);

            ExpressionxportablereadstreamModule expressionxportablreadstreamModule = ExpressionxportablereadstreamModule.Action(Filename_VALUE, expressionxportablreadfileModule.ExpressionxportablereadfilePort);

            ExpressionxportablereadbuildModule expressionxportablreadbuildModule = ExpressionxportablereadbuildModule.Action(Filename_VALUE, expressionxportablreadfileModule.ExpressionxportablereadfilePort, expressionxportablreadstreamModule.ExpressionxportablereadstreamPort);

            var inflect = new Object[3];

            inflect[0] = expressionxportablreadfileModule;

            inflect[1] = expressionxportablreadstreamModule;

            inflect[2] = expressionxportablreadbuildModule;

            Expressionxportablereadclose.Close(value_EXPRESSIONXPORTABLEREADCLOSE, inflect);

            var result = inflect;

            arrayResult = result;

            return arrayResult;
        }
    }
}
