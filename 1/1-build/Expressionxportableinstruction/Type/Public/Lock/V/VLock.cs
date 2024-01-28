using Core;

namespace Core
{
    using System;

    public partial class Expressionxportableinstruction
    {
        public static void VLock(Expressionxportable value_EXPRESSIONXPORTABLE, String Lock_VALUE)
        {
            try
            {
                View(value_EXPRESSIONXPORTABLE);

                Lock(value_EXPRESSIONXPORTABLE, Lock_VALUE);
            }
            catch (Exception exception)
            {
                var information = new String[] {

                    nameof(VLock)
                };

                Expressionxportablerender.RenderError($"{ExpressionxportableCode.ProductPath.Core_Expressionxportable_Fatal}", new Expressionxportableinstructionfatal.Lock().Initialize(information, exception));
            }

            return;
        }
    }
}
