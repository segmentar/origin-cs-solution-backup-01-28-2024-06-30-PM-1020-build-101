using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class ExpressionxportablewritefileModule
    {
        public static ExpressionxportablewritefileModule Action(String Filename_VALUE, Expressionxportablelayout value_EXPRESSIONXPORTABLELAYOUT, Expressionxportablewriteclose value_EXPRESSIONXPORTABLEWRITECLOSE, ExpressionxportablewritebuildPort value_EXPRESSIONXPORTABLEWRITEBUILDPORT, ExpressionxportablewritestreamPort value_EXPRESSIONXPORTABLEWRITESTREAMPORT)
        {
            ExpressionxportablewritefileModule module;

            module = Default(Filename_VALUE, value_EXPRESSIONXPORTABLELAYOUT, value_EXPRESSIONXPORTABLEWRITECLOSE, value_EXPRESSIONXPORTABLEWRITEBUILDPORT, value_EXPRESSIONXPORTABLEWRITESTREAMPORT);

            if (ExpressionxportablePolicy.ExpressionxportablewritefilePolicy is true)
            {
                try
                {
                    Expressionxportablerender.Render($"{ExpressionxportableCode.ProductPath.Core_Expressionxportable_Render}-{ExpressionxportablePolicy.ExpressionxportableIdentityOrdinalPolicy}x{ExpressionxportablePolicy.ExpressionxportableIdentityPolicy}-{nameof(ExpressionxportablewritefileModule)}-0", ExpressionxportablewritefileCycle.XZeroth);

                    Expressionxportablerender.Render($"{ExpressionxportableCode.ProductPath.Core_Expressionxportable_Render}-{ExpressionxportablePolicy.ExpressionxportableIdentityOrdinalPolicy}x{ExpressionxportablePolicy.ExpressionxportableIdentityPolicy}-{nameof(ExpressionxportablewritefileModule)}-1", ExpressionxportablewritefileCycle.XPrimary.XSingle);
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
