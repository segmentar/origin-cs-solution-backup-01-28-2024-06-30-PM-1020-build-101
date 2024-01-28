using Core;

namespace Core
{
    using System;

    public partial class Expressionxportableinstruction
    {
        public static void IRelease(Expressionxportable value_EXPRESSIONXPORTABLE)
        {
            try
            {
                var list = Expressionxportablemagic.ExpressionxportablemagicLinkedListCastDispenser<Object>(Expressionxportable.ViewLinkedListObject);

                list.Clear();

                Expressionxportable.InternalSelfObject = value_EXPRESSIONXPORTABLE;

            } catch (Exception exception)
            {
                var information = new String[]
                {
                    nameof(IRelease)
                };

                Expressionxportablerender.RenderError($"{ExpressionxportableCode.ProductPath.Core_Expressionxportable_Fatal}", new Expressionxportableinstructionfatal.Release().Initialize(information, exception));
            }

            return;
        }
    }
}