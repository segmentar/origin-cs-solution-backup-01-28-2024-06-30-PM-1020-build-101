using Core;

namespace Core
{
    using System;

    public partial class Expressionxportableinstruction
    {
        public static Expressionxportable ISView(Expressionxportable value_EXPRESSIONXPORTABLE)
        {
            Expressionxportable expressionxportableResult = default;

            try
            {
                IView(value_EXPRESSIONXPORTABLE);

                var reflect = (Expressionxportable)(Expressionxportable.InternalSelfObject as Object);

                var result = reflect;

                expressionxportableResult = result;

            } catch (Exception exception)
            {
                var information = new String[] {

                    nameof(ISView)
                };

                Expressionxportablerender.RenderError($"{ExpressionxportableCode.ProductPath.Core_Expressionxportable_Fatal}", new Expressionxportableinstructionfatal.View().Initialize(information, exception));
            }

            return expressionxportableResult;
        }
    }
}
