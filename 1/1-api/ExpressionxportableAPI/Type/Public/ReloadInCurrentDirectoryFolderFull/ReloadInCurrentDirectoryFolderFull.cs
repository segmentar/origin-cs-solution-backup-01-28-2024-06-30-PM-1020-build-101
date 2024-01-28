using Core;

namespace Core
{
    using System;

    public partial class Expressionxportableapi
    {
        public static Expressionxportable ReloadInCurrentDirectoryFolderFull(Expressionxportable expressionxportable, String folderName, String fileName)
        {
            Expressionxportable expressionxportableResult = default;

            expressionxportableResult = Expressionxportablereload.GroupReloadInCurrentDirectoryFolderFull(expressionxportable, folderName, fileName);

            return expressionxportableResult;
        }
    }
}
