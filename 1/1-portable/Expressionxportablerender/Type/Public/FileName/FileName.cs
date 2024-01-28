using Core;

namespace Core
{
    using System;

    public partial class Expressionxportablerender
    {
        public static String FileName(String[] Split_ARRAY, Int32 Ordinal_VALUE)
        {
            String stringResult = default;

            var aoth = Split_ARRAY.Length;

            var roth = (aoth - 1);

            var eoth = Split_ARRAY[roth];

            var format = String.Format("{0} {1}", eoth, Ordinal_VALUE);

            var result = format;

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
