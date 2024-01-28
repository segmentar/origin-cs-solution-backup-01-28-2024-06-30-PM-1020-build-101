using Core;

namespace Core
{
    using System;

    public partial class Expressionxportablesafe
    {
        public static Char[] ForgeCharacterArray(Char[] array_CHARACTER)
        {
            Char[] arrayResult = default;

            var aoth = array_CHARACTER.Length;

            var array = new Char[aoth];

            var indexer = 0;

            foreach (Char value_CHARACTER in array_CHARACTER)
            {
                var result = ForgeCharacter(value_CHARACTER);

                array[indexer] = result;

                indexer = indexer + 1;

                continue;
            }

            arrayResult = array;

            return arrayResult;
        }
    }
}
