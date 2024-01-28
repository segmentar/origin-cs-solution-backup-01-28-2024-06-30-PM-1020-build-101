using Core;

namespace Core
{
    using System;

    public partial class Expressionxportable
    {
        static Expressionxportable()
        {
            return;
        }

        public static void Procedure()
        {
            ExpressionxportablePolicy.ExpressionxportableDebugPolicy = true;

            ExpressionxportablePolicy.ExpressionxportableInfoPolicy = true;

            return;
        }

        public static void Manual()
        {
            Expressionxportableconfigure.Import(Expressionxportableconfigure.Data());

            /*var result = ExpressionxportableRootVariation();

            Expressionxportablesavecontext expressionxportablesavecohtext;

            expressionxportablesavecohtext = new Expressionxportablesavecontext();

            expressionxportablesavecohtext.ShouldRemote = true;

            Expressionxportablesave.SaveToSpace(result, expressionxportablesavecohtext);*/

            return;
        }

        public static void Raise()
        {
            if (ExpressionxportablePolicy.ExpressionxportableInfoPolicy is true)
            {
                Expressionxportablerender.Render($"{ExpressionxportableCode.RenderPath.Core_Expressionxportable_Info}-{nameof(Expressionxportable)}Info", Expressionxportablemagic.ExpressionxportablemagicArrayListCastDispenser(ExpressionxportablePolicy.ExpressionxportableArrayListObject).ToArray());
            }
            else
                "false".ToString();

            return;
        }

        public static void Bundle()
        {
            Procedure();

            Manual();

            Raise();

            return;
        }
    }
}
