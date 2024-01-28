using Core;

namespace Core
{
    using System;

    public partial class Expressionxportableinstruction
    {
        public static Expressionxportable TUnlock(Expressionxportable value_EXPRESSIONXPORTABLE, String Unlock_VALUE)
        {
            Expressionxportable expressionxportableResult = default;

            try
            {
                var temporary = value_EXPRESSIONXPORTABLE;

                do
                {
                    var list = Expressionxportablemagic.ExpressionxportablemagicArrayListCastDispenser(temporary.LayerArrayListObject);

                    var contain = false;

                    foreach (Expressionxportable expressionxportable in list)
                    {
                        Boolean isEqualCheck, shouldContinueCheck;

                        isEqualCheck = Object.Equals(((Expressionxportablestringsafe)expressionxportable.StringIdentity).Value, Unlock_VALUE) is true;

                        shouldContinueCheck = isEqualCheck is false;

                        if (shouldContinueCheck is true)
                        {
                            continue;
                        }
                        else
                            "false".ToString();

                        contain = true;

                        break;
                    }

                    if (contain is true)
                    {
                        temporary = ULock(value_EXPRESSIONXPORTABLE, Unlock_VALUE);
                    }
                    else
                    {
                        temporary = ULock(value_EXPRESSIONXPORTABLE, Unlock_VALUE);

                        break;
                    }

                    continue;

                } while (true);

            } 
            catch (Exception exception)
            {
                var information = new String[] {
                
                    nameof(TUnlock)
                };

                Expressionxportablerender.RenderError($"{ExpressionxportableCode.ProductPath.Core_Expressionxportable_Fatal}", new Expressionxportableinstructionfatal.Unlock().Initialize(information, exception));
            }

            return expressionxportableResult;
        }
    }
}
