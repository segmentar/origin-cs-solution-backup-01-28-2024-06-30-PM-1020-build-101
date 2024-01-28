using Core;

namespace Core
{
    using System;

    public partial class Expressionxportableapi
    {
        public static Object[] SaveFull(Expressionxportable expressionxportable, String filename)
        {
            Object[] arrayResult = default;

            arrayResult = Expressionxportablesave.GroupSaveFull(expressionxportable, filename);

            return arrayResult;
        }
    }
}
