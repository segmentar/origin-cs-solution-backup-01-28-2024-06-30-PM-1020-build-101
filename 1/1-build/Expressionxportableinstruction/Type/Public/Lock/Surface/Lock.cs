using Core;

namespace Core
{
    using System;

    public partial class Expressionxportableinstruction
    {
        public static void Lock(Expressionxportable value_EXPRESSIONXPORTABLE, String Lock_VALUE)
        {
            try
            {
                ILock(value_EXPRESSIONXPORTABLE, Lock_VALUE);

            } catch (Exception exception)
            {
                var information = new String[] {

                    nameof(Lock)
                };

                Expressionxportablerender.RenderError($"{ExpressionxportableCode.ProductPath.Core_Expressionxportable_Fatal}", new Expressionxportableinstructionfatal.Lock().Initialize(information, exception));
            }

            return;
        }
    }
}
