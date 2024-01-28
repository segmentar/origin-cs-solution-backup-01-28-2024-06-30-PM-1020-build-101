using Core;

namespace Core
{
    using System;

    public partial class Expressionxportableapi
    {
        public static Expressionxportable ReloadInCurrentDirectoryFull(Expressionxportable expressionxportable, String fileName)
        {
            Expressionxportable expressionxportableResult = default;

            expressionxportableResult = Expressionxportablereload.GroupReloadInCurrentDirectoryFull(expressionxportable, fileName);

            return expressionxportableResult;
        }
    }
}
