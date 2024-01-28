using Core;

namespace Core
{
    using System;

    public partial class Expressionxportableinstruction
    {
        public static void Cut(Expressionxportable value_EXPRESSIONXPORTABLE, String Cut_VALUE)
        {
            try
            {
                ICut(value_EXPRESSIONXPORTABLE, Cut_VALUE);
            }
            catch (Exception exception)
            {
                var information = new String[] {

                    nameof(Cut)
                };

                Expressionxportablerender.RenderError($"{ExpressionxportableCode.ProductPath.Core_Expressionxportable_Fatal}", new Expressionxportableinstructionfatal.Cut().Initialize(information, exception));
            }

            return;
        }
    }
}
