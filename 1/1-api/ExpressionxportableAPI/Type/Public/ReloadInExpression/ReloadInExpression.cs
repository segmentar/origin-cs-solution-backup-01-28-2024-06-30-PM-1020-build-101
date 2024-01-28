using Core;

namespace Core
{
    using System;

    public partial class Expressionxportableapi
    {
        public static Expressionxportable ReloadInExpression(Expressionxportable expressionxportable, Expressionxportablesavecontext expressionxportablesavecontext, Expressionxportablewriteclose expressionxportablewriteclose, Expressionxportableloadcontext expressionxportableloadcontext, Expressionxportablereadclose expressionxportablereadclose, Expressionxportablereloadcontext expressionxportablereloadcontext, String fileName)
        {
            Expressionxportable expressionxportableResult = default;

            expressionxportableResult = Expressionxportablereload.GroupReloadInExpression(expressionxportable, expressionxportablesavecontext, expressionxportablewriteclose, expressionxportableloadcontext, expressionxportablereadclose, expressionxportablereloadcontext, fileName);

            return expressionxportableResult;
        }
    }
}
