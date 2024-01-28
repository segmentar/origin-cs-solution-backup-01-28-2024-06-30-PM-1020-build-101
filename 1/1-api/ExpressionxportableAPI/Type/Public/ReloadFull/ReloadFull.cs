using Core;

namespace Core
{
    using System;

    public partial class Expressionxportableapi
    {
        public static Object[] ReloadFull(Expressionxportable expressionxportable, String filename)
        {
            Object[] arrayResult = default;

            arrayResult = Expressionxportablereload.GroupReloadFull(expressionxportable, filename);

            return arrayResult;
        }
    }
}
