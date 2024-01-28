using Core;

namespace Core
{
    using System;

    public partial class Expressionxportableexecute
    {
        public static void ExecuteText(Expressionxportable value_EXPRESSIONXPORTABLE, String Text_VALUE)
        {
            Expressionxportableexecutetext expressionxportableexecutetext;

            expressionxportableexecutetext = new Expressionxportableexecutetext();

            expressionxportableexecutetext.ExecuteText = Text_VALUE;

            value_EXPRESSIONXPORTABLE.ObjectIdentity = expressionxportableexecutetext;

            return;
        }
    }
}
