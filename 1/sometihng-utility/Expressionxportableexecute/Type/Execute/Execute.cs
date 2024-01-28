using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class Expressionxportableexecute
    {
        public static Expressionxportable Execute(Expressionxportable value_EXPRESSIONXPORTABLE, String[] Execute_ARRAY, Expressionxportablesavecontext value_EXPRESSIONXPORTABLESAVECONTEXT, Expressionxportableloadcontext value_EXPRESSIONXPORTABLELOADCONTEXT)
        {
            Expressionxportable expressionResult = default;

            var format = String.Format("{0} {1} {2} {3}", ExpressionxportablePolicy.ExpressionxportableIdentityOrdinalPolicy, DateTime.Now.ToLongDateString(), DateTime.Now.ToLongTimeString(), Path.GetRandomFileName());

            var split = format.Split(Path.GetInvalidFileNameChars(), StringSplitOptions.None);

            var join = String.Join(Expressionxportableascii.EntityWhitespace.ToString(), split);

            ExpressionxportablePolicy.ExpressionxportableIdentityOrdinalPolicy = ExpressionxportablePolicy.ExpressionxportableIdentityOrdinalPolicy + 1;

            ExpressionxportablePolicy.ExpressionxportableIdentityPolicy = join;

            /*if (Object.Equals(Expressionxportable.SpaceObject.GetType(), typeof(Object)) is true)
            {
                Expressionxportableloadcontext expressionxportableloadcontext;

                expressionxportableloadcontext = new Expressionxportableloadcontext();

                expressionxportableloadcontext.ShouldExecute = true;

                expressionxportableloadcontext.ShouldFilesystem = true;

                expressionxportableloadcontext.ShouldDestroy = false;

                var value = Expressionxportableload.LoadFromSpace(expressionxportableloadcontext);

                Expressionxportable.SpaceObject = value;
            }
            else
                "false".ToString();*/

            Expressionxportableexecutearray expressionxportableexecutearray;

            expressionxportableexecutearray = new Expressionxportableexecutearray();

            expressionxportableexecutearray.ExecuteArray = Execute_ARRAY;

            value_EXPRESSIONXPORTABLE.ObjectIdentity = expressionxportableexecutearray;

            var name = Path.GetRandomFileName();

            //Expressionxportablesave.GroupSaveToCurrentDirectory(value_EXPRESSIONXPORTABLE, name, value_EXPRESSIONXPORTABLESAVECONTEXT);

            //var result = Expressionxportableload.LoadFromCurrentDirectory(name, value_EXPRESSIONXPORTABLELOADCONTEXT);

            //expressionResult = result;

            return expressionResult;
        }
    }
}
