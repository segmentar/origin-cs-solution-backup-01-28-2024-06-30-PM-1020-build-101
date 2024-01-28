using Core;

namespace Core
{
    using System;

    public partial class Expressionxportableinstruction
    {
        public static Expressionxportable ISLock(Expressionxportable value_EXPRESSIONXPORTABLE, String Lock_VALUE)
        {
            Expressionxportable expressionxportableResult = default;
            
            try
            {
                ILock(value_EXPRESSIONXPORTABLE, Lock_VALUE);

                var reflect = (Expressionxportable)(Expressionxportable.InternalSelfObject as Object);

                expressionxportableResult = reflect;
            }
            catch (Exception exception)
            {
                var information = new String[] {

                    nameof(ISLock)
                };

                Expressionxportablerender.RenderError($"{ExpressionxportableCode.ProductPath.Core_Expressionxportable_Fatal}", new Expressionxportableinstructionfatal.Lock().Initialize(information, exception));
            }

            return expressionxportableResult;
        }
    }
}
