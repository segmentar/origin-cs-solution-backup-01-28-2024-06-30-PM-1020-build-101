using Core;

namespace Core
{
    using System;

    public partial class Expressionxportableapi
    {
        public static Expressionxportable LoadFromCurrentDirectory(Expressionxportableloadcontext expressionxportableloadcontext, Expressionxportablereadclose expressionxportablereadclose, String fileName)
        {
            Expressionxportable expressionxportableResult = default;

            expressionxportableResult = Expressionxportableload.GroupLoadFromCurrentDirectory(expressionxportableloadcontext, expressionxportablereadclose, fileName);

            return expressionxportableResult;
        }
    }
}
