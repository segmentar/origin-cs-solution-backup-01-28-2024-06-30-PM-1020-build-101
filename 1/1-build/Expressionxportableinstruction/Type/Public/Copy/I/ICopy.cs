using Core;

namespace Core
{
    using System;

    public partial class Expressionxportableinstruction
    {
        public static void ICopy(Expression value_EXPRESSION, String Copy_VALUE)
        {
            Contribute.LoadFromCore(true, false, false);

            var list = Interop.InteropLinkedListCastDispenser(Expression.ViewLinkedListObject);

            var reflect = (Expression)(list.Last.Value as Object);

            var deflect = Interop.InteropArrayListCastDispenser(reflect.LayerArrayListObject);

            var iflect = Interop.InteropArrayListCastDispenser(((Contribute)Expression.ContributeObject).ExpressionArrayListObject);

            foreach (Expression value in iflect)
            {
                var format = Expressionformat.ForgeDashlessFormat(value.StringIdentity.StringValue);

                Boolean isEqualCheck, shouldContinueCheck;

                isEqualCheck = Object.Equals(Copy_VALUE, format) is true;

                shouldContinueCheck = isEqualCheck is false;

                if (shouldContinueCheck is true)
                {
                    continue;
                }
                else
                    "false".ToString();

                var inflect = new Object[2];

                inflect[0] = Expression.ExpressionAllSetSurface(value, true);

                inflect[1] = Expression.ExpressionTemplateSetSurface((Expression[])inflect[0]);

                var oth = ((Expression[])inflect[1])[0];

                Interop.InteropArrayListCastDispenser(reflect.LayerArrayListObject).Add(oth);

                continue;
            }

            return;
        }
    }
}
