using Core;

namespace Core
{
    using System;

    public partial class Bootxportablesafe
    {
        public static String GroupString(String value_STRING)
        {
            String stringResult = default;

            var data = value_STRING.ToCharArray();

            var value = GroupCharacterArray(data);

            var result = new String(value);

            stringResult = result; 

            return stringResult;
        }
    }
}
