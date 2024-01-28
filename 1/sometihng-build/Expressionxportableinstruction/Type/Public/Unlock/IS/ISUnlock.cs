using Core;

namespace Core
{
    using System;

    public partial class Expressionxportableinstruction
    {
        public static Expressionxportable ISUnlock(Expressionxportable value_EXPRESSIONXPORTABLE, String Unlock_VALUE)
        {
            Expressionxportable expressionxportableResult = default;

            try
            {
                IUnlock(value_EXPRESSIONXPORTABLE, Unlock_VALUE);

                var reflect = (Expressionxportable)(Expressionxportable.InternalSelfObject as Object);

                var result = reflect;

                expressionxportableResult = result;
            } 
            catch (Exception exception)
            {
                var information = new String[] {

                    nameof(ISUnlock)
                };

                Expressionxportablerender.RenderError($"{ExpressionxportableCode.ProductPath.Core_Expressionxportable_Fatal}", new Expressionxportableinstructionfatal.Unlock().Initialize(information, exception));
            }

            return expressionxportableResult;
        }
    }
}
