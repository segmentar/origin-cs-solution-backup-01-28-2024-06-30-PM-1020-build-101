using Core;

namespace Core
{
    using System;

    public partial class Expressionxportablereload
    {
        public static Object[] GroupReloadFull(Expressionxportable value_EXPRESSIONXPORTABLE, String Filename_VALUE)
        {
            Object[] arrayResult = default;

            var inflect = new Object[5];

            inflect[0] = Expressionxportablesavecontext.Data();

            inflect[1] = Expressionxportablewriteclose.Data();

            inflect[2] = Expressionxportableloadcontext.Data();

            inflect[3] = Expressionxportablereadclose.Data();

            inflect[4] = Expressionxportablereloadcontext.Data();

            var array = GroupReload(value_EXPRESSIONXPORTABLE, (Expressionxportablesavecontext)inflect[0], (Expressionxportablewriteclose)inflect[1], (Expressionxportableloadcontext)inflect[2], (Expressionxportablereadclose)inflect[3], (Expressionxportablereloadcontext)inflect[4], Filename_VALUE);

            arrayResult = array;

            return arrayResult;
        }
    }
}
