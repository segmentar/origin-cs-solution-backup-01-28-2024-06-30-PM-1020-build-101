using Core;

namespace Core
{
    using System;

    public partial class Bootxportablesafe
    {
        public static Char[] GroupCharacterArray(Char[] array_CHARACTER)
        {
            Char[] arrayResult = default;

            var aoth = array_CHARACTER.Length;

            var array = new Char[aoth];

            array_CHARACTER.CopyTo(array, BootxportablePolicy.BootxportableIndexPolicy);

            var index = 0;

            foreach (Char character in array)
            {
                var value = array[index];

                var result = GroupCharacter(value);

                array[index] = result;

                index = index + 1;

                continue;
            }

            arrayResult = array;

            return arrayResult;
        }
    }
}
