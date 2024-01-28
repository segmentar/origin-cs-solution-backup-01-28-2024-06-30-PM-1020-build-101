using Core;

namespace Core
{
    using System;

    public partial class Expressionxportablesave
    {
        public static void GroupSaveToCurrentDirectoryFull(Expressionxportable value_EXPRESSIONXPORTABLE, String FileName__VALUE)
        {
            var inflect = new Object[2];

            inflect[0] = Expressionxportablesavecontext.Data();

            inflect[1] = Expressionxportablewriteclose.Data();

            GroupSaveToCurrentDirectory(value_EXPRESSIONXPORTABLE, (Expressionxportablesavecontext)inflect[0], (Expressionxportablewriteclose)inflect[1], FileName__VALUE);

            return;
        }
    }
}
