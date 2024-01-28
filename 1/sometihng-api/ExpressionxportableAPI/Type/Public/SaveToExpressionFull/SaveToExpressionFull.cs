using Core;

namespace Core
{
    using System;

    public partial class Expressionxportableapi
    {
        public static void SaveToExpressionFull(Expressionxportable expressionxportable, String fileName)
        {
            Expressionxportablesave.GroupSaveToExpressionFull(expressionxportable, fileName);

            return;
        }
    }
}
