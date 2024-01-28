using Core;

namespace Core
{
    using System;

    public partial class Expressionxportableinstruction
    {
        public static void Unlock(Expressionxportable value_EXPRESSIONXPORTABLE, String Unlock_VALUE)
        {
            try
            {
                IUnlock(value_EXPRESSIONXPORTABLE, Unlock_VALUE);
            }
            catch (Exception exception)
            {
                var information = new String[] { 
                
                    nameof(Unlock)
                };

                Expressionxportablerender.RenderError($"{ExpressionxportableCode.ProductPath.Core_Expressionxportable_Fatal}", new Expressionxportableinstructionfatal.Unlock().Initialize(information, exception));
            }

            return;
        }
    }
}
