using Core;

namespace Core
{
    using System;

    public partial class Expressionxportableapi
    {
        public static void SaveToExpression(Expressionxportable expressionxportable, Expressionxportablesavecontext expressionxportablesavecontext, Expressionxportablewriteclose expressionxportablewriteclose, String fileName)
        {
            Expressionxportablesave.GroupSaveToExpression(expressionxportable, expressionxportablesavecontext, expressionxportablewriteclose, fileName);

            return;
        }
    }
}
