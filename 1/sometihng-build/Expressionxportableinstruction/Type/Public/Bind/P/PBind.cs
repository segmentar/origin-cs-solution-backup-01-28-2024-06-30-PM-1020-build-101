using Core;

namespace Core
{
    using System;

    public partial class Expressionxportableinstruction
    {
        public static void PBind(Expression value_EXPRESSION, String Bind_VALUE)
        {
            var list = Interop.InteropLinkedListCastDispenser(Expression.ViewLinkedListObject);

            var parse = Decimal.Parse(Bind_VALUE);

            var reflect = (Expression)(list.Last.Value as Object);

            reflect.PercentIdentity = parse;

            return;
        }
    }
}
