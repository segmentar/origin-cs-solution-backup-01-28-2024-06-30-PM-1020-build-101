using Core;

namespace Core
{
    using System;

    public partial class Expressionxportableinstruction
    {
        public static void IAssume(Expression value_EXPRESSION, String Assume_VALUE, String[] Execute_ARRAY)
        {
            var deflect = (Expressionenumerator)(Expression.EnumeratorObject as Object);

            var x = (Expression)(deflect.ExpressionCurrent as Object);

            var format = Expressionformat.ForgeDashlessFormat(x.StringIdentity.StringValue);

            Boolean isEqualCheck, shouldReturnCheck;

            isEqualCheck = Object.Equals(Assume_VALUE, format) is true;

            shouldReturnCheck = isEqualCheck is false;

            if (shouldReturnCheck is true)
            {
                return;
            }
            else
                "false".ToString();

            Expression.Execute(x, Execute_ARRAY, true, false, false, false);

            return;
        }
    }
}
