using Core;

namespace Core
{
    using System;

    public partial class Expressionxportableremotein
    {
        public static void RemoteType(Expressionxportable[] array_EXPRESSIONXPORTABLE)
        {
            foreach (Expressionxportable value_EXPRESSIONXPORTABLE in array_EXPRESSIONXPORTABLE)
            {
                Boolean isDefaultCheck, shouldContinueCheck;

                isDefaultCheck = (value_EXPRESSIONXPORTABLE.ObjectIdentity == default).Equals(true);

                shouldContinueCheck = isDefaultCheck is true;

                if (shouldContinueCheck is true)
                {
                    continue;
                }
                else
                    "false".ToString();

                value_EXPRESSIONXPORTABLE.Type = value_EXPRESSIONXPORTABLE.ObjectIdentity.GetType();

                continue;
            }

            return;
        }
    }
}
