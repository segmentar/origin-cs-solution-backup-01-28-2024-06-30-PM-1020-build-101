using Core;

namespace Core
{
    using System;

    public partial class Expressionxportableapi
    {
        public static Expressionxportable LoadFromCurrentDirectoryFolderFull(String folderName, String fileName)
        {
            Expressionxportable expressionxportableResult = default;

            expressionxportableResult = Expressionxportableload.GroupLoadFromCurrentDirectoryFolderFull(folderName, fileName);

            return expressionxportableResult;
        }
    }
}
