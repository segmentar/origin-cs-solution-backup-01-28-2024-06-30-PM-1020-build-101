using Core;

namespace Core
{
    using System;

    public partial class Expressionxportableapi
    {
        public static void SaveToCurrentDirectoryFolderFull(Expressionxportable expressionxportable, String folderName, String fileName)
        {
            Expressionxportablesave.GroupSaveToCurrentDirectoryFolderFull(expressionxportable, folderName, fileName);

            return;
        }
    }
}
