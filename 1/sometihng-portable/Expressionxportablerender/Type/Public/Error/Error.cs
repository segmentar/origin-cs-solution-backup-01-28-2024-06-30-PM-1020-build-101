using Core;

namespace Core
{
    using System;

    public partial class Expressionxportablerender
    {
        public static String Error()
        {
            String stringResult = default;

            var concat = String.Concat(String.Empty, "This object just so happned to be default", ' ', ":(");

            var result = concat;

            stringResult = result;

            try
            {

            } catch (Exception exception)
            {
                Expressionxportablerenderlog.Log(exception);
            }

            return stringResult;
        }
    }
}
