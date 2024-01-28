using Core;

namespace Core
{
    using System;

    public partial class Expressionxportableinstruction
    {
        public static void Release(Expressionxportable value_EXPRESSIONXPORTABLE)
        {
            try
            {
                IRelease(value_EXPRESSIONXPORTABLE);

            } catch (Exception exception)
            {
                var information = new String[]
                {
                    nameof(Release)
                };

                Expressionxportablerender.RenderError($"{ExpressionxportableCode.ProductPath.Core_Expressionxportable_Fatal}", new Expressionxportableinstructionfatal.Release().Initialize(information, exception));
            }

            return;
        }
    }
}