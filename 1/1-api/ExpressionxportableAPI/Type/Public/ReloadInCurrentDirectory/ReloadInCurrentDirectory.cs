using Core;

namespace Core
{
    using System;

    public partial class Expressionxportableapi
    {
        public static Expressionxportable ReloadInCurrentDirectory(Expressionxportable expressionxportable, Expressionxportablesavecontext expressionxportablesavecontext, Expressionxportablewriteclose expressionxportablewriteclose, Expressionxportableloadcontext expressionxportableloadcontext, Expressionxportablereadclose expressionxportablereadclose, Expressionxportablereloadcontext expressionxportablereloadcontext, String fileName)
        {
            Expressionxportable expressionxportableResult = default;

            expressionxportableResult = Expressionxportablereload.GroupReloadInCurrentDirectory(expressionxportable, expressionxportablesavecontext, expressionxportablewriteclose, expressionxportableloadcontext, expressionxportablereadclose, expressionxportablereloadcontext, fileName);

            return expressionxportableResult;
        }
    }
}
