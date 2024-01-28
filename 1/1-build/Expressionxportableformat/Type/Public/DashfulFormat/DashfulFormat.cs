using Core;

namespace Core
{
    using System;

    public partial class Expressionxportableformat
    {
        public static String DashfulFormat(String Input_VALUE)
        {
            String stringResult = default;

            var split = Input_VALUE.Split(Expressionxportableradical.EntityNormalRadical, StringSplitOptions.RemoveEmptyEntries);

            var join = String.Join(((Char)Expressionxportableascii.EntityDash).ToString(), split);

            var result = join;

            stringResult = result;

            return stringResult;
        }
    }
}
