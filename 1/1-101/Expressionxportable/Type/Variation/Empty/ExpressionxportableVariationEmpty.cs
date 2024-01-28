using Core;

namespace Core
{
    using System;

    public partial class Expressionxportable
    {
        public static Expressionxportable ExpressionxportableEmptyVariation()
        {
            Expressionxportable expressionxportableResult = default;

            Expressionxportable expressionxportable;

            expressionxportable = new ExpressionxportableSimple(String.Empty, default(Object)).Result;

            expressionxportableResult = expressionxportable;

            return expressionxportableResult;
        }
    }
}
