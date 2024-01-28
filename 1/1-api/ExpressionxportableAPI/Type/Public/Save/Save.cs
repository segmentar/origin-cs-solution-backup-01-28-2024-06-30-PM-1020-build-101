using Core;

namespace Core
{
    using System;

    public partial class Expressionxportableapi
    {
        public static Object[] Save(Expressionxportable expressionxportable, Expressionxportablesavecontext expressionxportablesavecontext, Expressionxportablewriteclose expressionxportablewriteclose, String fileName)
        {
            Object[] arrayResult = default;

            arrayResult = Expressionxportablesave.GroupSave(expressionxportable, expressionxportablesavecontext, expressionxportablewriteclose, fileName);

            return arrayResult;
        }
    }
}
