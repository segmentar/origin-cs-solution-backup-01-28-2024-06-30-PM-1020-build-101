using Core;

namespace Core
{
    using System;

    public partial class Expressionxportableapi
    {
        public static Object[] Load(Expressionxportableloadcontext expressionxportableloadcontext, Expressionxportablereadclose expressionxportablereadclose, String filename)
        {
            Object[] arrayResult = default;

            arrayResult = Expressionxportableload.GroupLoad(expressionxportableloadcontext, expressionxportablereadclose, filename);

            return arrayResult;
        }
    }
}
