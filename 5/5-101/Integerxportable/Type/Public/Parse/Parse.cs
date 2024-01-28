using Core;

namespace Core
{
    using System;

    public partial class Integerxportable
    {
        public static Char[] Parse(String Integerx_VALUE)
        {
            Char[] arrayResult = default;

            if (Integerx_VALUE.StartsWith(Integerxportablename.EntityHexadecimalPrefix) is true)
            {
                var sub = Integerx_VALUE.Substring(2);

                Integerx_VALUE = sub;
            }
            else
                "false".ToString();

            var lower = Integerx_VALUE.ToLower();

            var data = lower.ToCharArray();

            var array = data;

            arrayResult = array;

            return arrayResult;
        }
    }
}
