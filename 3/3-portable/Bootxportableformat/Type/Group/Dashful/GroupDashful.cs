using Core;

namespace Core
{
    using System;

    public partial class Bootxportableformat
    {
        public static String GroupDashful(String value_STRING)
        {
            String stringResult = default;

            var trim = value_STRING.Trim(Bootxportableradical.EntityFormat);

            var split = trim.Split(Bootxportableradical.EntityFormat, StringSplitOptions.RemoveEmptyEntries);

            var join = String.Join(((Char)Bootxportableascii.EntityDash).ToString(), split);

            var result = join;

            stringResult = result;

            return stringResult;
        }
    }
}
