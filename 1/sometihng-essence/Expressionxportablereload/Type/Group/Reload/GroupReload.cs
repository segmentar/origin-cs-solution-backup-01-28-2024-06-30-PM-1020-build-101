using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class Expressionxportablereload
    {
        public static Object[] GroupReload(Expressionxportable value_EXPRESSIONXPORTABLE, Expressionxportablesavecontext value_EXPRESSIONXPORTABLESAVECONTEXT, Expressionxportablewriteclose value_EXPRESSIONXPORTABLEWRITECLOSE, Expressionxportableloadcontext value_EXPRESSIONXPORTABLELOADCONTEXT, Expressionxportablereadclose value_EXPRESSIONXPORTABLEREADCLOSE, Expressionxportablereloadcontext value_EXPRESSIONXPORTABLERELOADCONTEXT, String Filename_VALUE)
        {
            Object[] arrayResult = default;

            if (value_EXPRESSIONXPORTABLERELOADCONTEXT.DebugShould is true)
            {
                ExpressionxportablePolicy.ExpressionxportableIdentityPolicy = Path.GetRandomFileName();

                ExpressionxportablePolicy.ExpressionxportableIdentityOrdinalPolicy = ExpressionxportablePolicy.ExpressionxportableIdentityOrdinalPolicy + 1;

                value_EXPRESSIONXPORTABLESAVECONTEXT.DebugShould = false;

                value_EXPRESSIONXPORTABLERELOADCONTEXT.DebugShould = false;
            }
            else
                "false".ToString();

            Expressionxportablesave.GroupSave(value_EXPRESSIONXPORTABLE, value_EXPRESSIONXPORTABLESAVECONTEXT, value_EXPRESSIONXPORTABLEWRITECLOSE, Filename_VALUE);

            var array = Expressionxportableload.GroupLoad(value_EXPRESSIONXPORTABLELOADCONTEXT, value_EXPRESSIONXPORTABLEREADCLOSE, Filename_VALUE);

            arrayResult = array;

            if (value_EXPRESSIONXPORTABLERELOADCONTEXT.ExecuteShould is true)
            {       
                ExpressionxportableexecuteSeal.ZeroZeroth(((ExpressionxportablereadbuildModule)array[2]).ExpressionxportablereadbuildPort.ExpressionxportableArray);

                ExpressionxportablemoduleSeal.ZeroZeroth(((ExpressionxportablereadbuildModule)array[2]).ExpressionxportablereadbuildPort.ExpressionxportableArray);
            }
            else
                "false".ToString();

            return arrayResult;
        }
    }
}
