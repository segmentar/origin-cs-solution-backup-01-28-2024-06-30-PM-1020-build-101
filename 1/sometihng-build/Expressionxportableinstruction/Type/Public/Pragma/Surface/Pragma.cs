using Core;

namespace Core
{
    using System;

    public partial class Expressionxportableinstruction
    {
        public static void Pragma(Expressionxportable value_EXPRESSIONXPORTABLE, String Pragma_VALUE)
        {
            try
            {
                ICut(value_EXPRESSIONXPORTABLE, Pragma_VALUE);
            }
            catch (Exception exception)
            {
                var information = new String[] {

                    nameof(Pragma)
                };

                Expressionxportablerender.RenderError($"{ExpressionxportableCode.ProductPath.Core_Expressionxportable_Fatal}", new Expressionxportableinstructionfatal.Pragma().Initialize(information, exception));
            }

            return;
        }
    }
}
