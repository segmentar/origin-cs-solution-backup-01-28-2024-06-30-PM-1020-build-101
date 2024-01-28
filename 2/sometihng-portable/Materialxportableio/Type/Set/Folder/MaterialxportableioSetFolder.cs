using Core;

namespace Core
{
    using System;

    using System.IO;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class Materialxportableio
    {
        public static IList<DirectoryInfo> FunctionFolderSet(String Directory_VALUE, Boolean answer_SELF_should)
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

            var item = Directory.GetDirectories(Directory_VALUE);

            foreach (String value in item)
            {
                var entry = FunctionFolderSetSurface(value, answer_SELF_should);

                foreach (DirectoryInfo result in entry)
                {
                    collectionResult.Add(result);

                    continue;
                }

                continue;
            }

            return new List<DirectoryInfo>(collectionResult);
        }
    }
}
