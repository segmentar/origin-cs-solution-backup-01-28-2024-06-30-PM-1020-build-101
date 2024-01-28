using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class Expressionxportableexecute
    {
        public static void ExecuteFile(Expressionxportable value_EXPRESSIONXPORTABLE, String Text_VALUE)
        {
            Expressionxportableexecutetext expressionxportableexecutetext;

            expressionxportableexecutetext = new Expressionxportableexecutetext();

            expressionxportableexecutetext.ExecuteText = Text_VALUE;

            var list = Expressionxportablemagic.ExpressionxportablemagicArrayListCastDispenser(value_EXPRESSIONXPORTABLE.LayerArrayListObject);

            Expressionxportable expressionxportable;

            expressionxportable = new ExpressionxportableSimple(Path.GetRandomFileName(), expressionxportableexecutetext).Result;

            list.Add(expressionxportable);

            return;
        }
    }
}
