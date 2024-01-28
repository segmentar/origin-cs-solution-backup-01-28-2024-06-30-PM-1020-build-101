using Core;

namespace Core
{
    using System;

    public partial class Expressionxportableinstruction
    {
        public static void IUnlock(Expressionxportable value_EXPRESSIONXPORTABLE, String Unlock_VALUE)
        {
            try
            {
                ULock(value_EXPRESSIONXPORTABLE, Unlock_VALUE);

                var reflect = (Expressionxportable)(Expressionxportable.InternalSelfObject as Object);

                View(reflect);
            } 
            catch (Exception exception)
            {
                var information = new String[] {

                    nameof(IUnlock)
                };

                Expressionxportablerender.RenderError($"{ExpressionxportableCode.ProductPath.Core_Expressionxportable_Fatal}", new Expressionxportableinstructionfatal.Unlock().Initialize(information, exception));
            }

            return;
        }
    }
}
