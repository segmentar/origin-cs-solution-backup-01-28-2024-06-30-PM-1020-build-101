using Core;

namespace Core
{
    using System;

    public partial class Expressionxportableinstruction
    {
        public static void View(Expressionxportable value_EXPRESSIONXPORTABLE)
        {
            try
            {
                IView(value_EXPRESSIONXPORTABLE);

            } catch (Exception exception)
            {
                var information = new String[] {

                    nameof(View)
                };

                Expressionxportablerender.RenderError($"{ExpressionxportableCode.ProductPath.Core_Expressionxportable_Fatal}", new Expressionxportableinstructionfatal.View().Initialize(information, exception));
            }

            return;
        }
    }
}
