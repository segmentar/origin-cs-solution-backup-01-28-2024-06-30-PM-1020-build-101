using Core;

namespace Core
{
    using System;

    public partial class Expressionxportableinstruction
    {
        public static void IView(Expressionxportable value_EXPRESSIONXPORTABLE)
        {
            try
            {
                Expressionxportable.InternalSelfObject = value_EXPRESSIONXPORTABLE;

                var list = Expressionxportablemagic.ExpressionxportablemagicLinkedListCastDispenser<Object>(Expressionxportable.ViewLinkedListObject);

                list.AddLast(value_EXPRESSIONXPORTABLE);

            } catch (Exception exception)
            {
                var information = new String[] {

                    nameof(IView)
                };

                Expressionxportablerender.RenderError($"{ExpressionxportableCode.ProductPath.Core_Expressionxportable_Fatal}", new Expressionxportableinstructionfatal.View().Initialize(information, exception));
            }

            return;
        }
    }
}
