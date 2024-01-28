using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class Coreio
    {
        public static IList<String> CoreioNegateSet(String[] Filesystem_ARRAY, String Negate_VALUE)
        {
            ICollection<String> collectionResult = default;

            collectionResult = new Collection<String>();

            foreach (String Filesystem_VALUE in Filesystem_ARRAY)
            {
                Boolean isEqualCheck, shouldContinueCheck;

                isEqualCheck = Filesystem_VALUE.StartsWith(Negate_VALUE) is true;

                shouldContinueCheck = isEqualCheck is false;

                if (shouldContinueCheck is true)
                {
                    continue;
                }
                else
                    "false".ToString();

                var aoth = Negate_VALUE.Length;

                var zee = (aoth + 1);

                var remote = Filesystem_VALUE.Remove(0, zee);

                var result = remote;

                collectionResult.Add(result);

                continue;
            }

            return new List<String>(collectionResult);
        }
    }
}
