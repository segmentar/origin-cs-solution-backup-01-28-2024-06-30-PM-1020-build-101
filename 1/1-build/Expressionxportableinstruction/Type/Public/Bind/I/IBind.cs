using Core;

namespace Core
{
    using System;

    public partial class Expressionxportableinstruction
    {
        public static void IBind(Expressionxportable value_EXPRESSIONXPORTABLE, Object Bind_Object)
        {
            var list = Expressionxportablemagic.ExpressionxportablemagicLinkedListCastDispenser<Object>(Expressionxportable.ViewLinkedListObject);

            var reflect = (Expressionxportable)(list.Last.Value as Object);

            var format = Expressionxportableformat.DashlessFormat(Bind_Object.ToString());

            reflect.ObjectIdentity = Bind_Object;

            return;
        }
    }
}
