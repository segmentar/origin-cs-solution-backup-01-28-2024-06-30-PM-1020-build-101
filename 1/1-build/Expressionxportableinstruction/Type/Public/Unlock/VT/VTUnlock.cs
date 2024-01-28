using Core;

namespace Core
{
    using System;

    public partial class Expressionxportableinstruction
    {
        public static void VTUnlock(Expressionxportable value_EXPRESSIONXPORTABLE, String Unlock_VALUE)
        {
            try
            {
                View(value_EXPRESSIONXPORTABLE);

                TUnlock(value_EXPRESSIONXPORTABLE, Unlock_VALUE);
            }
            catch (Exception exception)
            {
                var information = new String[] { 

                    nameof(VTUnlock)
                };

                Expressionxportablerender.RenderError($"{ExpressionxportableCode.ProductPath.Core_Expressionxportable_Fatal}", new Expressionxportableinstructionfatal.Unlock().Initialize(information, exception));
            }
        }
    }
}
