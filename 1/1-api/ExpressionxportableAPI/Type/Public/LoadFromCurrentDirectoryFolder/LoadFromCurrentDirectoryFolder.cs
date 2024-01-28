using Core;

namespace Core
{
    using System;

    public partial class Expressionxportableapi
    {
        public static Expressionxportable LoadFromCurrentDirectoryFolder(Expressionxportableloadcontext expressionxportableloadcontext, Expressionxportablereadclose expressionxportablereadclose, String folderName, String fileName)
        {
            Expressionxportable expressionxportableResult = default;

            expressionxportableResult = Expressionxportableload.GroupLoadFromCurrentDirectoryFolder(expressionxportableloadcontext, expressionxportablereadclose, folderName, fileName);

            return expressionxportableResult;
        }
    }
}
