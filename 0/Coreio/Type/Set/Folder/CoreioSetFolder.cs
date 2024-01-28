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
        public static IList<DirectoryInfo> CoreioFolderSet(String DirectoryFullName___VALUE, Boolean answer_SELF_should)
        {
            ICollection<DirectoryInfo> collectionResult = default;

            collectionResult = new Collection<DirectoryInfo>();

            if (answer_SELF_should is true)
            {
                DirectoryInfo directoryInfo;

                directoryInfo = new DirectoryInfo(DirectoryFullName___VALUE);

                collectionResult.Add(directoryInfo);
            }
            else
                "false".ToString();

            var item = Directory.GetDirectories(DirectoryFullName___VALUE);

            foreach (String stringValue in item)
            {
                var entry = CoreioFolderSetSurface(stringValue, answer_SELF_should);

                foreach (var value in entry)
                {
                    collectionResult.Add(value);

                    continue;
                }

                continue;
            }

            return new List<DirectoryInfo>(collectionResult);
        }
    }
}
