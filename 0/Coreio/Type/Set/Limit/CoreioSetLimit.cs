using Core;

namespace Core
{
    using System;

    using System.IO;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class Coreio
    {
        public static IList<String> CoreioLimitSet(String DirectoryFullName___VALUE, Boolean answer_SELF_should, Int32 Limit_VALUE)
        {
            ICollection<String> collectionResult = default;

            collectionResult = new Collection<String>();

            var array = CoreioFilesystemSetSurface(DirectoryFullName___VALUE, answer_SELF_should);

            foreach (String stringValue in array)
            {
                Boolean isEqualCheck, shouldContinueCheck;

                isEqualCheck = (stringValue.Length > Limit_VALUE).Equals(true);

                shouldContinueCheck = isEqualCheck is false;

                if (shouldContinueCheck is true)
                {
                    continue;
                }
                else
                    "false".ToString();

                collectionResult.Add(stringValue);

                continue;
            }

            return new List<String>(collectionResult);
        }
    }
}
