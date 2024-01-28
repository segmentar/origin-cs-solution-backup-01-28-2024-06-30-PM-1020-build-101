using Core;

namespace Core
{
    using System;

    public partial class ExpressionxportablereadbuildModule
    {
        public static ExpressionxportablereadbuildModule Action(String Filename_VALUE, ExpressionxportablereadfilePort value_EXPRESSIONXPORTABLEREADFILEPORT, ExpressionxportablereadstreamPort value_EXPRESSIONXPORTABLEREADSTREAMPORT)
        {
            ExpressionxportablereadbuildModule moduleResult = default;

            moduleResult = Default(Filename_VALUE, value_EXPRESSIONXPORTABLEREADFILEPORT, value_EXPRESSIONXPORTABLEREADSTREAMPORT);

            if (ExpressionxportablePolicy.ExpressionxportablereadbuildPolicy is true)
            {
                try
                {
                    Expressionxportablerender.Render($"{ExpressionxportableCode.ProductPath.Core_Expressionxportable_Render}-{ExpressionxportablePolicy.ExpressionxportableIdentityOrdinalPolicy}x{ExpressionxportablePolicy.ExpressionxportableIdentityPolicy}-{nameof(ExpressionxportablereadbuildModule)}-0", ExpressionxportablereadbuildCycle.XZeroth);

                    Expressionxportablerender.Render($"{ExpressionxportableCode.ProductPath.Core_Expressionxportable_Render}-{ExpressionxportablePolicy.ExpressionxportableIdentityOrdinalPolicy}x{ExpressionxportablePolicy.ExpressionxportableIdentityPolicy}-{nameof(ExpressionxportablereadbuildModule)}-1", ExpressionxportablereadbuildCycle.XPrimary.XSingle);

                    Expressionxportablerender.Render($"{ExpressionxportableCode.ProductPath.Core_Expressionxportable_Render}-{ExpressionxportablePolicy.ExpressionxportableIdentityOrdinalPolicy}x{ExpressionxportablePolicy.ExpressionxportableIdentityPolicy}-{nameof(ExpressionxportablereadbuildModule)}-2", ExpressionxportablereadbuildCycle.XSecondary.XDouble);

                    Expressionxportablerender.Render($"{ExpressionxportableCode.ProductPath.Core_Expressionxportable_Render}-{ExpressionxportablePolicy.ExpressionxportableIdentityOrdinalPolicy}x{ExpressionxportablePolicy.ExpressionxportableIdentityPolicy}-{nameof(ExpressionxportablereadbuildModule)}-3", ExpressionxportablereadbuildCycle.XTertiary.XTriple);

                    Expressionxportablerender.Render($"{ExpressionxportableCode.ProductPath.Core_Expressionxportable_Render}-{ExpressionxportablePolicy.ExpressionxportableIdentityOrdinalPolicy}x{ExpressionxportablePolicy.ExpressionxportableIdentityPolicy}-{nameof(ExpressionxportablereadbuildModule)}-4", ExpressionxportablereadbuildCycle.XQuaternary.XQuadruple);
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
