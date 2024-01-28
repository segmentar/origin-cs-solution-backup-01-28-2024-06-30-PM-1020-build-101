using Core;

namespace Core
{
    using System;

    using System.IO;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class Coregithub
    {

        public static IList<String> CoregithubSetResourceFull(String DirectoryFullName___VALUE)
        {
            ICollection<String> collectionResult = default;

            collectionResult = new Collection<String>();

            var value = Directory.GetDirectories(DirectoryFullName___VALUE);

            var result = CoregithubSetResourceSurface(value);

            foreach (DirectoryInfo directoryInfo in result)
            {
                var array = Coreio.CoreioFilesystemSetSurface(directoryInfo.FullName, true);

                foreach (String stringValue in array)
                {
                    collectionResult.Add(stringValue);

                    continue;
                }

                continue;
            }

            return new List<String>(collectionResult);
        }
    }
}
