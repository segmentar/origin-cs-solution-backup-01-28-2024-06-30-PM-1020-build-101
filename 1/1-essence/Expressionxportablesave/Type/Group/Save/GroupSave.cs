using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class Expressionxportablesave
    {
        public static Object[] GroupSave(Expressionxportable value_EXPRESSIONXPORTABLE, Expressionxportablesavecontext value_EXPRESSIONXPORTABLESAVECONTEXT, Expressionxportablewriteclose value_EXPRESSIONXPORTABLEWRITECLOSE, String Filename_VALUE)
        {
            Object[] arrayResult = default;

            var array = Expressionxportableset.ExpressionxportableAllSetSurface(value_EXPRESSIONXPORTABLE, true);

            if (value_EXPRESSIONXPORTABLESAVECONTEXT.RemoteShould is true)
            {
                Expressionxportableremotein.RemoteType(array);

                Expressionxportableremotein.Remote(array);
            }
            else
                "false".ToString();

            var value = Expressionxportablelayout.Data(array);

            if (value_EXPRESSIONXPORTABLESAVECONTEXT.DebugShould)
            {
                ExpressionxportablePolicy.ExpressionxportableIdentityPolicy = Path.GetRandomFileName();

                ExpressionxportablePolicy.ExpressionxportableIdentityOrdinalPolicy = ExpressionxportablePolicy.ExpressionxportableIdentityOrdinalPolicy + 1;
            }
            else
                "false".ToString();

            ExpressionxportablewritebuildModule expressionxportablewritebuildModule = ExpressionxportablewritebuildModule.Action(Filename_VALUE, array, value);

            ExpressionxportablewritestreamModule expressionxportablewritestreamModule = ExpressionxportablewritestreamModule.Action(Filename_VALUE, array, value, expressionxportablewritebuildModule.ExpressionxportablewritebuildPort);

            ExpressionxportablewritefileModule expressionxportablewritefileModule = ExpressionxportablewritefileModule.Action(Filename_VALUE, value, value_EXPRESSIONXPORTABLEWRITECLOSE, expressionxportablewritebuildModule.ExpressionxportablewritebuildPort, expressionxportablewritestreamModule.ExpressionxportablewritestreamPort);

            var inflect = new Object[3];

            inflect[0] = expressionxportablewritebuildModule;

            inflect[1] = expressionxportablewritestreamModule;

            inflect[2] = expressionxportablewritefileModule;

            Expressionxportablewriteclose.Close(value_EXPRESSIONXPORTABLEWRITECLOSE, inflect);

            var result = inflect;

            arrayResult = result;

            return arrayResult;
        }
    }
}
