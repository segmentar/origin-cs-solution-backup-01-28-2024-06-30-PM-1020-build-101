using Core;

namespace Core
{
    using System;

    public partial class Expressionxportableschedule
    {
        public static void GroupScheduleLine(Expressionxportable value_EXPRESSIONXPORTABLE, String[] array_STRING)
        {
            Expressionxportableexecutearray expressionxportableexecutearray;

            expressionxportableexecutearray = new Expressionxportableexecutearray();

            expressionxportableexecutearray.ExecuteArray = array_STRING;

            value_EXPRESSIONXPORTABLE.ObjectIdentity = expressionxportableexecutearray;

            return;
        }
    }
}
