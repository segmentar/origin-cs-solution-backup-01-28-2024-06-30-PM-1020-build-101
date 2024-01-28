using Core;

namespace Core
{
    using System;

    public partial class Expressionxportableexecute
    {
        public static Expressionxportable ExecuteFull(Expressionxportable value_EXPRESSIONXPORTABLE, String[] Execute_ARRAY)
        {
            Expressionxportable expressionResult = default;

            Expressionxportablesavecontext expressionxportablesavecontext;

            expressionxportablesavecontext = new Expressionxportablesavecontext();

            expressionxportablesavecontext.RemoteShould = true;

            Expressionxportableloadcontext expressionxportableloadcontext;

            expressionxportableloadcontext = new Expressionxportableloadcontext();

            expressionxportableloadcontext.ShouldExecute = true;

            expressionxportableloadcontext.ShouldFilesystem = true;

            expressionxportableloadcontext.ShouldDestroy = true;

            var result = Execute(value_EXPRESSIONXPORTABLE, Execute_ARRAY, expressionxportablesavecontext, expressionxportableloadcontext);

            expressionResult = result;

            return expressionResult;
        }
    }
}
