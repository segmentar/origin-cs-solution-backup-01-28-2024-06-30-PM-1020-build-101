using Core;

namespace Core
{
    using System;

    using System.Collections;

    public partial class Expressionxportableinstruction
    {
        public static void ICut(Expressionxportable value_EXPRESSIONXPORTABLE, String Cut_VALUE)
        {
            try
            {
                var deflect = new IEnumerable[2];

                var inflect = new Object[1];

                inflect[0] = Expressionxportablemagic.ExpressionxportablemagicLinkedListCastDispenser<Object>(Expressionxportable.ViewLinkedListObject).Last.Value;

                deflect[0] = Expressionxportablemagic.ExpressionxportablemagicArrayListCastDispenser(((Expressionxportable)inflect[0]).LayerArrayListObject);

                deflect[1] = Expressionxportablemagic.ExpressionxportablemagicArrayListDispenser((ArrayList)deflect[0]);

                foreach (Expressionxportable expressionxportable in Expressionxportablemagic.ExpressionxportablemagicArrayListCastDispenser(deflect[1]))
                {
                    var format = Expressionxportableformat.DashlessFormat(Cut_VALUE);

                    Boolean isEqualCheck, shouldContinueCheck;

                    isEqualCheck = Object.Equals(((Expressionxportablestringsafe)expressionxportable.StringIdentity).Value, format) is true;

                    shouldContinueCheck = isEqualCheck is false;

                    if (shouldContinueCheck is true)
                    {
                        continue;
                    }
                    else
                        "false".ToString();

                    Expressionxportablemagic.ExpressionxportablemagicArrayListCastDispenser(((Expressionxportable)inflect[0]).LayerArrayListObject).Remove(expressionxportable);

                    //Expressionxportablemagic.ExpressionxportablemagicArrayListCastDispenser(((Expressionxportable)Expressionxportable.SpaceObject).LayerArrayListObject).Add(expressionxportable);

                    continue;
                }
            }
            catch (Exception exception)
            {
                var information = new String[] {

                    nameof(ICut)
                };

                Expressionxportablerender.RenderError($"{ExpressionxportableCode.ProductPath.Core_Expressionxportable_Fatal}", new Expressionxportableinstructionfatal.Cut().Initialize(information, exception));
            }

            return;
        }
    }
}
