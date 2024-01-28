using Core;

namespace Core
{
    using System;

    public partial class Expressionxportableapi
    {
        public static void SaveToCurrentDirectoryFull(Expressionxportable expressionxportable, String fileName)
        {
            Expressionxportablesave.GroupSaveToCurrentDirectoryFull(expressionxportable, fileName);

            return;
        }
    }
}
