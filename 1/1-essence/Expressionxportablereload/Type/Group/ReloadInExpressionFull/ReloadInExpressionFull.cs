using Core;

namespace Core
{
    using System;

    public partial class Expressionxportablereload
    {
        public static Expressionxportable GroupReloadInExpressionFull(Expressionxportable value_EXPRESSIONXPORTABLE, String FileName__VALUE)
        {
            Expressionxportable expressionxportableResult = default;

            var inflect = new Object[5];

            inflect[0] = Expressionxportablesavecontext.Data();

            inflect[1] = Expressionxportablewriteclose.Data();

            inflect[2] = Expressionxportableloadcontext.Data();

            inflect[3] = Expressionxportablereadclose.Data();

            inflect[4] = Expressionxportablereloadcontext.Data();

            var result = GroupReloadInExpression(value_EXPRESSIONXPORTABLE, (Expressionxportablesavecontext)inflect[0], (Expressionxportablewriteclose)inflect[1], (Expressionxportableloadcontext)inflect[2], (Expressionxportablereadclose)inflect[3], (Expressionxportablereloadcontext)inflect[4], FileName__VALUE);

            expressionxportableResult = result;

            return expressionxportableResult;
        }
    }
}
