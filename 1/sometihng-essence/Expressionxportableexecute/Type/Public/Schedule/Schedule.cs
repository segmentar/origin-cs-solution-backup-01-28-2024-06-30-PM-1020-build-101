using Core;

namespace Core
{
    using System;

    public partial class Expressionxportableexecute
    {
        public static void Schedule(Expressionxportable value_EXPRESSIONXPORTABLE, String[] Execute_ARRAY, String[] Header_ARRAY)
        {
            Expressionxportableexecutecontext expressionxportableexecutecontext;

            expressionxportableexecutecontext = new Expressionxportableexecutecontext();

            var join = String.Join(((Char)Expressionxportableascii.EntityDash).ToString(), Header_ARRAY);

            var format = String.Format("{0} {1}", Expressionxportablename.EntityInstructionPragma, join);

            expressionxportableexecutecontext.Header = format;

            expressionxportableexecutecontext.ExecuteArray = Execute_ARRAY;

            value_EXPRESSIONXPORTABLE.ObjectIdentity = expressionxportableexecutecontext;

            return;
        }
    }
}
