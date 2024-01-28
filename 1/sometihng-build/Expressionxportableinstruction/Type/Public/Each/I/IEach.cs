using Core;

namespace Core
{
    using System;

    public partial class Expressionxportableinstruction
    { 
        public static void IEach(Expression value_EXPRESSION, String[] Execute_ARRAY)
        {
            var list = Interop.InteropLinkedListCastDispenser(Expression.ViewLinkedListObject);

            var reflect = (Expression)(list.Last.Value as Object);
   
            var result = Expressionenumerator.MakeExpressionenumeratorStructure(reflect);

            Expression.EnumeratorObject = result;

            do
            {
                if (result.MoveNext() is false)
                {
                    break;
                }
                else
                    "false".ToString();

                var deflect = (Expression)(result.ExpressionCurrent as Object);

                var value = Expression.ExecuteFull(deflect, Execute_ARRAY);

                var x = Interop.InteropArrayListCastDispenser(((Expression)(result.ExpressionTarget as Object)).LayerArrayListObject);

                x[(result.Position - 1)] = value;;

                continue;

            } while (true);

            return;
        }
    }
}
