using Core;

namespace Core
{
    using System;

    public partial class Expressionxportableapi
    {
        public static Expressionxportable ReloadInExpressionFull(Expressionxportable expressionxportable, String fileName)
        {
            Expressionxportable expressionxportableResult = default;

            expressionxportableResult = Expressionxportablereload.GroupReloadInExpressionFull(expressionxportable, fileName);

            return expressionxportableResult;
        }
    }
}
