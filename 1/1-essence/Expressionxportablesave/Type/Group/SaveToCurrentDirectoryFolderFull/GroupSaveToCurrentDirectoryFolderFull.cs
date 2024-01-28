using Core;

namespace Core
{
    using System;

    public partial class Expressionxportablesave
    {
        public static void GroupSaveToCurrentDirectoryFolderFull(Expressionxportable value_EXPRESSIONXPORTABLE, String FolderName__VALUE, String FileName__VALUE)
        {
            var inflect = new Object[2];

            inflect[0] = Expressionxportablesavecontext.Data();

            inflect[1] = Expressionxportablewriteclose.Data();

            GroupSaveToCurrentDirectoryFolder(value_EXPRESSIONXPORTABLE, (Expressionxportablesavecontext)inflect[0], (Expressionxportablewriteclose)inflect[1], FolderName__VALUE, FileName__VALUE);

            return;
        }
    }
}
