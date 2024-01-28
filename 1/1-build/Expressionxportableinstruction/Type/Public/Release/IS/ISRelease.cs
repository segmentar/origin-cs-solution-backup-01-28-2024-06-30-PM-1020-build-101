using Core;

namespace Core
{
    using System;

    public partial class Expressionxportableinstruction
    {
        public static Expressionxportable ISRelease(Expressionxportable value_EXPRESSIONXPORTABLE)
        {
            Expressionxportable expressionxportableResult = default;

            try
            {
                IRelease(value_EXPRESSIONXPORTABLE);

                var reflect = (Expressionxportable)(Expressionxportable.InternalSelfObject as Object);

                expressionxportableResult = reflect;

            } catch (Exception exception)
            {
                var information = new String[]
{
                    nameof(ISRelease)
};

                Expressionxportablerender.RenderError($"{ExpressionxportableCode.ProductPath.Core_Expressionxportable_Fatal}", new Expressionxportableinstructionfatal.Release().Initialize(information, exception));
            }

            return expressionxportableResult;
        }
    }
}
