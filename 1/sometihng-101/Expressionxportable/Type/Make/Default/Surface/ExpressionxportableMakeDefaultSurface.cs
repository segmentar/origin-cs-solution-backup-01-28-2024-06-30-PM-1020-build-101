using Core;

namespace Core
{
    using System;

    public partial class Expressionxportable
    {
        public static Expressionxportable MakeExpressionxportableDefaultSurface(Expressionxportablestringsafe value_EXPRESSIONXPORTABLESTRINGSAFE, Object value_OBJECT)
        {
            Expressionxportable expressionxportableResult = default;

            expressionxportableResult = MakeExpressionxportableDefault(value_EXPRESSIONXPORTABLESTRINGSAFE, value_OBJECT, ExpressionxportablePolicy.ExpressionxportableDebugPolicy);

            return expressionxportableResult;
        }
    }
}
