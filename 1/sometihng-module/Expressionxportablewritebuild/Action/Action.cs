using Core;

namespace Core
{
    using System;

    public partial class ExpressionxportablewritebuildModule
    {
        public static ExpressionxportablewritebuildModule Action(String Filename_VALUE, Expressionxportable[] array_EXPRESSIONXPORTABLE, Expressionxportablelayout value_EXPRESSIONXPORTABLELAYOUT)
        {
            ExpressionxportablewritebuildModule module;

            module = Default(Filename_VALUE, array_EXPRESSIONXPORTABLE, value_EXPRESSIONXPORTABLELAYOUT);

            if (ExpressionxportablePolicy.ExpressionxportablewritebuildPolicy is true)
            {
                try
                {
                    Expressionxportablerender.Render($"{ExpressionxportableCode.ProductPath.Core_Expressionxportable_Render}-{ExpressionxportablePolicy.ExpressionxportableIdentityOrdinalPolicy}x{ExpressionxportablePolicy.ExpressionxportableIdentityPolicy}-{nameof(ExpressionxportablewritebuildModule)}-0", ExpressionxportablewritebuildCycle.XZeroth);

                    Expressionxportablerender.Render($"{ExpressionxportableCode.ProductPath.Core_Expressionxportable_Render}-{ExpressionxportablePolicy.ExpressionxportableIdentityOrdinalPolicy}x{ExpressionxportablePolicy.ExpressionxportableIdentityPolicy}-{nameof(ExpressionxportablewritebuildModule)}-1", ExpressionxportablewritebuildCycle.XPrimary.XSingle);

                    Expressionxportablerender.Render($"{ExpressionxportableCode.ProductPath.Core_Expressionxportable_Render}-{ExpressionxportablePolicy.ExpressionxportableIdentityOrdinalPolicy}x{ExpressionxportablePolicy.ExpressionxportableIdentityPolicy}-{nameof(ExpressionxportablewritebuildModule)}-2", ExpressionxportablewritebuildCycle.XSecondary.XDouble);

                    Expressionxportablerender.Render($"{ExpressionxportableCode.ProductPath.Core_Expressionxportable_Render}-{ExpressionxportablePolicy.ExpressionxportableIdentityOrdinalPolicy}x{ExpressionxportablePolicy.ExpressionxportableIdentityPolicy}-{nameof(ExpressionxportablewritebuildModule)}-3", ExpressionxportablewritebuildCycle.XTertiary.XTriple);

                    Expressionxportablerender.Render($"{ExpressionxportableCode.ProductPath.Core_Expressionxportable_Render}-{ExpressionxportablePolicy.ExpressionxportableIdentityOrdinalPolicy}x{ExpressionxportablePolicy.ExpressionxportableIdentityPolicy}-{nameof(ExpressionxportablewritebuildModule)}-4", ExpressionxportablewritebuildCycle.XQuaternary.XQuadruple);

                    Expressionxportablerender.Render($"{ExpressionxportableCode.ProductPath.Core_Expressionxportable_Render}-{ExpressionxportablePolicy.ExpressionxportableIdentityOrdinalPolicy}x{ExpressionxportablePolicy.ExpressionxportableIdentityPolicy}-{nameof(ExpressionxportablewritebuildModule)}-5", ExpressionxportablewritebuildCycle.XQuinary.XQuintuple);

                    Expressionxportablerender.Render($"{ExpressionxportableCode.ProductPath.Core_Expressionxportable_Render}-{ExpressionxportablePolicy.ExpressionxportableIdentityOrdinalPolicy}x{ExpressionxportablePolicy.ExpressionxportableIdentityPolicy}-{nameof(ExpressionxportablewritebuildModule)}-6", ExpressionxportablewritebuildCycle.XSenary.XSextuple);

                    Expressionxportablerender.Render($"{ExpressionxportableCode.ProductPath.Core_Expressionxportable_Render}-{ExpressionxportablePolicy.ExpressionxportableIdentityOrdinalPolicy}x{ExpressionxportablePolicy.ExpressionxportableIdentityPolicy}-{nameof(ExpressionxportablewritebuildModule)}-7", ExpressionxportablewritebuildCycle.XSeptenary.XSeptuple);
                }
                catch (Exception exception)
                {
                    Expressionxportablerender.Render($"{ExpressionxportableCode.ProductPath.Core_Expressionxportable_Fatal}", exception);
                }
            }
            else
                "false".ToString();

            return module;
        }
    }
}
