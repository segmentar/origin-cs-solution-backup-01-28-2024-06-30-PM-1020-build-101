using Core;

namespace Core
{
    using System;

    public partial class Expressionxportablerender
    {
        public static String Normalize(String PathName__VALUE)
        {
            String stringResult = default;

            var separator = new Char[] { (Char)Expressionxportableascii.EntityDash };

            var split = PathName__VALUE.Split(separator, StringSplitOptions.None);

            var join = String.Join(((Char)Expressionxportableascii.EntityUnderscore).ToString(), split);

            var result = join;

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
