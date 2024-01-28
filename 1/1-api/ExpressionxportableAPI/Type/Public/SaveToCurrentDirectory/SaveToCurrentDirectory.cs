using Core;

namespace Core
{
    using System;

    public partial class Expressionxportableapi
    {
        public static void SaveToCurrentDirectory(Expressionxportable expressionxportable, Expressionxportablesavecontext expressionxportablesavecontext, Expressionxportablewriteclose expressionxportablewriteclose, String fileName)
        {
            Expressionxportablesave.GroupSaveToCurrentDirectory(expressionxportable, expressionxportablesavecontext, expressionxportablewriteclose, fileName);

            return;
        }
    }
}
