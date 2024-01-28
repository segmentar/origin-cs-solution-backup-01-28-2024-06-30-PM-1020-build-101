using Core;

namespace Core
{
    using System;

    public partial struct Expressionxportablesavecontext
    {
        public static Expressionxportablesavecontext Data()
        {
            Expressionxportablesavecontext expressionxportablesavecontextResult = default;

            Expressionxportablesavecontext expressionxportablesavecontext;

            expressionxportablesavecontext = new Expressionxportablesavecontext();

            expressionxportablesavecontext.Bit16Should = false;

            expressionxportablesavecontext.Bit32Should = true;

            expressionxportablesavecontext.Bit64Should = false;

            expressionxportablesavecontext.DebugShould = true;

            expressionxportablesavecontext.RemoteShould = true;

            expressionxportablesavecontext.OverflowShould = false;

            expressionxportablesavecontextResult = expressionxportablesavecontext;

            return expressionxportablesavecontextResult;
        }
    }
}
