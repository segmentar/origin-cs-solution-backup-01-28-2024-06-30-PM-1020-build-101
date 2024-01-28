using Core;

namespace Core
{
    using System;

    public partial class Expressionxportableinstruction
    {
        public static void ILock(Expressionxportable value_EXPRESSIONXPORTABLE, String Lock_VALUE)
        {
            try
            {
                var list = Expressionxportablemagic.ExpressionxportablemagicLinkedListCastDispenser<Object>(Expressionxportable.ViewLinkedListObject);

                var reflect = (Expressionxportable)(list.Last.Value as Object);

                var format = Expressionxportableformat.DashlessFormat(Lock_VALUE);

                Expressionxportable expressionxportable;

                expressionxportable = new ExpressionxportableSimple(format, default(Object)).Result;

                Expressionxportablemagic.ExpressionxportablemagicArrayListCastDispenser(reflect.LayerArrayListObject).Add(expressionxportable);

                Expressionxportable.InternalSelfObject = expressionxportable;

            }
            catch (Exception exception)
            {
                var information = new String[] {

                    nameof(ILock)
                };

                Expressionxportablerender.RenderError($"{ExpressionxportableCode.ProductPath.Core_Expressionxportable_Fatal}", new Expressionxportableinstructionfatal.Lock().Initialize(information, exception));
            }

            return;
        }
    }
}
