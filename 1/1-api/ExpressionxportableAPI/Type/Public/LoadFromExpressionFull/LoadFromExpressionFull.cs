using Core;

namespace Core
{
    using System;

    public partial class Expressionxportableapi
    {
        public static Expressionxportable LoadFromExpressionFull(String fileName)
        {
            Expressionxportable expressionxportableResult = default;

            expressionxportableResult = Expressionxportableload.GroupLoadFromExpressionFull(fileName);

            return expressionxportableResult;
        }
    }
}
