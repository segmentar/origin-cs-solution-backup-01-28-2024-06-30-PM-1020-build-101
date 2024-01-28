using Core;

namespace Core
{
    using System;

    public partial class Expressionxportableapi
    {
        public static void SaveToCurrentDirectoryFolder(Expressionxportable expressionxportable, Expressionxportablesavecontext expressionxportablesavecontext, Expressionxportablewriteclose expressionxportablewriteclose, String folderName, String fileName)
        {
            Expressionxportablesave.GroupSaveToCurrentDirectoryFolder(expressionxportable, expressionxportablesavecontext, expressionxportablewriteclose, folderName, fileName);

            return;
        }
    }
}
