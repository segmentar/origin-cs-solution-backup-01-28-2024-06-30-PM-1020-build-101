using Core;

namespace Core
{
    using System;

    public partial class Expressionxportableinstruction
    {
        public static Expressionxportable ULock(Expressionxportable value_EXPRESSIONXPORTABLE, String Lock_VALUE)
        {
            Expressionxportable expressionxportableResult = default;

            try
            {
                var list = Expressionxportablemagic.ExpressionxportablemagicLinkedListCastDispenser<Object>(Expressionxportable.ViewLinkedListObject);

                var reflect = (Expressionxportable)(list.Last.Value as Object);

                var contain = false;

                var temporary = default(Expressionxportable);

                foreach (Expressionxportable expressionxportable in Expressionxportablemagic.ExpressionxportablemagicArrayListCastDispenser(reflect.LayerArrayListObject))
                {
                    temporary = expressionxportable;

                    Boolean isEqualCheck, shouldContinueCheck;

                    isEqualCheck = Object.Equals(((Expressionxportablestringsafe)expressionxportable.StringIdentity).Value, Lock_VALUE) is true;

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

                Boolean isContainContagentCheck;

                isContainContagentCheck = contain is true;

                if (isContainContagentCheck)
                {
                    IView(temporary);

                    expressionxportableResult = temporary;
                }
                else
                {
                    expressionxportableResult = ISLock(value_EXPRESSIONXPORTABLE, Lock_VALUE);
                }
            }
            catch (Exception exception)
            {
                var information = new String[] {

                    nameof(ULock)
                };

                Expressionxportablerender.RenderError($"{ExpressionxportableCode.ProductPath.Core_Expressionxportable_Fatal}", new Expressionxportableinstructionfatal.Lock().Initialize(information, exception));
            }

            return expressionxportableResult;
        }
    }
}
