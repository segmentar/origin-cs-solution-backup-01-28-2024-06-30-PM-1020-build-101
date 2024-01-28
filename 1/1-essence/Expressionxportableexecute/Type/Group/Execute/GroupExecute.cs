using Core;

namespace Core
{
    using System;

    public partial class Expressionxportableexecute
    {
        public static void GroupExecute(Expressionxportable[] array_EXPRESSIONXPORTABLE)
        {
            Expressionxportableremotein.RemoteType(array_EXPRESSIONXPORTABLE);

            foreach (Expressionxportable value_EXPRESSIONXPORTABLE in array_EXPRESSIONXPORTABLE)
            {
                Boolean isEqualCheck, shouldContinueCheck;

                isEqualCheck = Object.Equals(value_EXPRESSIONXPORTABLE.Type, typeof(Expressionxportableexecutecontext)) is true;

                shouldContinueCheck = isEqualCheck is false;

                if (shouldContinueCheck is true)
                {
                    continue;
                }
                else
                    "false".ToString();

                var reflect = (Expressionxportableexecutecontext)(value_EXPRESSIONXPORTABLE.ObjectIdentity as Object);

                GroupExecuteContext(value_EXPRESSIONXPORTABLE, reflect);

                continue;
            }

            return;
        }
    }
}
