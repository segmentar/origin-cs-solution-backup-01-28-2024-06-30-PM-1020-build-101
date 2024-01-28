using Core;

namespace Core
{
    using System;

    public partial class Expressionxportableload
    {
        public static Expressionxportable GroupLoadFromCurrentDirectoryFolderFull(String FolderName__VALUE, String FileName__VALUE)
        {
            Expressionxportable expressionxportableResult = default;

            var inflect = new Object[2];

            inflect[0] = Expressionxportableloadcontext.Data();

            inflect[1] = Expressionxportablereadclose.Data();

            var result = GroupLoadFromCurrentDirectoryFolder((Expressionxportableloadcontext)inflect[0], (Expressionxportablereadclose)inflect[1], FolderName__VALUE, FileName__VALUE);

            expressionxportableResult = result;

            return expressionxportableResult;
        }
    }
}
