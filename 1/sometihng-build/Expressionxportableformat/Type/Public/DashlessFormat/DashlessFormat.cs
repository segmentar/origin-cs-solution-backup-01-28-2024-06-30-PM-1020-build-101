using Core;

namespace Core
{
    using System;

    public partial class Expressionxportableformat
    {
        public static String DashlessFormat(String Input_VALUE)
        {
            String stringResult = default;

            var split = Input_VALUE.Split(Expressionxportableradical.EntityNormalRadical, StringSplitOptions.RemoveEmptyEntries);

            var join = String.Join(((Char)Expressionxportableascii.EntityUnderscore).ToString(), split);

            var result = join;

            stringResult = result;

            return stringResult;
        }
    }
}
