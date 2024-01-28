using Core;

namespace Core
{
    using System;

    public partial class Expressionxportableapi
    {
        public static Expressionxportable ReloadInCurrentDirectoryFolder(Expressionxportable expressionxportable, Expressionxportablesavecontext expressionxportablesavecontext, Expressionxportablewriteclose expressionxportablewriteclose, Expressionxportableloadcontext expressionxportableloadcontext, Expressionxportablereadclose expressionxportablereadclose, Expressionxportablereloadcontext expressionxportablereloadcontext, String folderName, String fileName)
        {
            Expressionxportable expressionxportableResult = default;

            expressionxportableResult = Expressionxportablereload.GroupReloadInCurrentDirectoryFolder(expressionxportable, expressionxportablesavecontext, expressionxportablewriteclose, expressionxportableloadcontext, expressionxportablereadclose, expressionxportablereloadcontext, folderName, fileName);

            return expressionxportableResult;
        }
    }
}
