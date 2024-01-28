using Core;

namespace Core
{
    using System;

    public partial class Expressionxportablesave
    {
        public static Object[] GroupSaveFull(Expressionxportable value_EXPRESSIONXPORTABLE, String Filename_VALUE)
        {
            Object[] arrayResult = default;

            var inflect = new Object[2];

            inflect[0] = Expressionxportablesavecontext.Data();

            inflect[1] = Expressionxportablewriteclose.Data();

            var array = GroupSave(value_EXPRESSIONXPORTABLE, (Expressionxportablesavecontext)inflect[0], (Expressionxportablewriteclose)inflect[1], Filename_VALUE);

            arrayResult = array;

            return arrayResult;
        }
    }
}
