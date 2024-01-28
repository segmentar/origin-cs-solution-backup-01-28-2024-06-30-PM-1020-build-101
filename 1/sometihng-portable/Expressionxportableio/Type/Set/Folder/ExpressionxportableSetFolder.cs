using Core;

namespace Core
{
    using System;

    using System.IO;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class Expressionxportableio
    {
        public static IList<DirectoryInfo> ExpressionxportableFolderSet(String Directory_VALUE, Boolean answer_SELF_should)
        {
            ICollection<DirectoryInfo> collectionResult = default;

            collectionResult = new Collection<DirectoryInfo>();

            if (answer_SELF_should is true)
            {
                DirectoryInfo directoryInfo;

                directoryInfo = new DirectoryInfo(Directory_VALUE);

                collectionResult.Add(directoryInfo);
            }
            else
                "false".ToString();

            foreach (String item in Directory.GetDirectories(Directory_VALUE))
            {
                var array = ExpressionxportableFolderSetSurface(item, answer_SELF_should);

                foreach (DirectoryInfo entry in array)
                {
                    collectionResult.Add(entry);

                    continue;
                }

                continue;
            }

            return new List<DirectoryInfo>(collectionResult);
        }
    }
}
