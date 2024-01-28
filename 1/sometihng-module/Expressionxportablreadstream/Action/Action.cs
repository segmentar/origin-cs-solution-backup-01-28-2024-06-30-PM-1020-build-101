using Core;

namespace Core
{
    using System;

    public partial class ExpressionxportablereadstreamModule
    {
        public static ExpressionxportablereadstreamModule Action(String Filename_VALUE, ExpressionxportablereadfilePort value_EXPRESSIONXPORTABLEREADFILEPORT)
        {
            ExpressionxportablereadstreamModule moduleResult = default;

            moduleResult = Default(Filename_VALUE, value_EXPRESSIONXPORTABLEREADFILEPORT);

            if (ExpressionxportablePolicy.ExpressionxportablereadstreamPolicy is true)
            {
                try
                {
                    Expressionxportablerender.Render($"{ExpressionxportableCode.ProductPath.Core_Expressionxportable_Render}-{ExpressionxportablePolicy.ExpressionxportableIdentityOrdinalPolicy}x{ExpressionxportablePolicy.ExpressionxportableIdentityPolicy}-{nameof(ExpressionxportablereadstreamModule)}-0", ExpressionxportablreadstreamCycle.XZeroth);

                    Expressionxportablerender.Render($"{ExpressionxportableCode.ProductPath.Core_Expressionxportable_Render}-{ExpressionxportablePolicy.ExpressionxportableIdentityOrdinalPolicy}x{ExpressionxportablePolicy.ExpressionxportableIdentityPolicy}-{nameof(ExpressionxportablereadstreamModule)}-1", ExpressionxportablreadstreamCycle.XPrimary.XSingle);
                }
                catch (Exception exception)
                {
                    Expressionxportablerender.Render($"{ExpressionxportableCode.ProductPath.Core_Expressionxportable_Fatal}", exception);
                }
            }
            else
                "false".ToString();

            return moduleResult;
        }
    }
}
