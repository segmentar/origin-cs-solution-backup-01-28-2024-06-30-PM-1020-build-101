using Core;

namespace Core
{
    using System;

    public partial class Expressionxportableinstruction
    {
        public static void VULock(Expressionxportable value_EXPRESSIONXPORTABLE, String Lock_VALUE)
        {
            try
            {
                View(value_EXPRESSIONXPORTABLE);

                ULock(value_EXPRESSIONXPORTABLE, Lock_VALUE);
            }
            catch (Exception exception)
            {
                var information = new String[] {

                    nameof(VULock)
                };

                Expressionxportablerender.RenderError($"{ExpressionxportableCode.ProductPath.Core_Expressionxportable_Fatal}", new Expressionxportableinstructionfatal.Lock().Initialize(information, exception));
            }

            return;
        }
    }
}
