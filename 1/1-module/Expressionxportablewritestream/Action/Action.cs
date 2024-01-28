using Core;

namespace Core
{
    using System;

    public partial class ExpressionxportablewritestreamModule
    {
        public static ExpressionxportablewritestreamModule Action(String Filename_VALUE, Expressionxportable[] array_EXPRESSIONXPORTABLE, Expressionxportablelayout value_EXPRESSIONXPORTABLELAYOUT, ExpressionxportablewritebuildPort value_EXPRESSIONXPORTABLEWRITEBUILDPORT)
        {
            ExpressionxportablewritestreamModule module;

            module = Default(Filename_VALUE, array_EXPRESSIONXPORTABLE, value_EXPRESSIONXPORTABLELAYOUT, value_EXPRESSIONXPORTABLEWRITEBUILDPORT);
            
            if (ExpressionxportablePolicy.ExpressionxportablewritestreamPolicy is true)
            {
                try
                {
                    Expressionxportablerender.Render($"{ExpressionxportableCode.ProductPath.Core_Expressionxportable_Render}-{ExpressionxportablePolicy.ExpressionxportableIdentityOrdinalPolicy}x{ExpressionxportablePolicy.ExpressionxportableIdentityPolicy}-{nameof(ExpressionxportablewritestreamModule)}-0", ExpressionxportablewriteCycle.XZeroth);

                    Expressionxportablerender.Render($"{ExpressionxportableCode.ProductPath.Core_Expressionxportable_Render}-{ExpressionxportablePolicy.ExpressionxportableIdentityOrdinalPolicy}x{ExpressionxportablePolicy.ExpressionxportableIdentityPolicy}-{nameof(ExpressionxportablewritestreamModule)}-1", ExpressionxportablewriteCycle.XPrimary.XSingle);

                    Expressionxportablerender.Render($"{ExpressionxportableCode.ProductPath.Core_Expressionxportable_Render}-{ExpressionxportablePolicy.ExpressionxportableIdentityOrdinalPolicy}x{ExpressionxportablePolicy.ExpressionxportableIdentityPolicy}-{nameof(ExpressionxportablewritestreamModule)}-2", ExpressionxportablewriteCycle.XSecondary.XDouble);

                    Expressionxportablerender.Render($"{ExpressionxportableCode.ProductPath.Core_Expressionxportable_Render}-{ExpressionxportablePolicy.ExpressionxportableIdentityOrdinalPolicy}x{ExpressionxportablePolicy.ExpressionxportableIdentityPolicy}-{nameof(ExpressionxportablewritestreamModule)}-3", ExpressionxportablewriteCycle.XTertiary.XTriple);
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
