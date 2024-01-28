using Core;

namespace Core
{
    using System;

    public partial class Expressionxportableapi
    {
        public static void Reload(Expressionxportable expressionxportable, Expressionxportablesavecontext expressionxportablesavecontext, Expressionxportablewriteclose expressionxportablewriteclose, Expressionxportableloadcontext expressionxportableloadcontext, Expressionxportablereadclose expressionxportablereadclose, Expressionxportablereloadcontext expressionxportablereloadcontext, String filename)
        {
            Expressionxportablereload.GroupReload(expressionxportable, expressionxportablesavecontext, expressionxportablewriteclose, expressionxportableloadcontext, expressionxportablereadclose, expressionxportablereloadcontext, filename);

            return;
        }
    }
}
