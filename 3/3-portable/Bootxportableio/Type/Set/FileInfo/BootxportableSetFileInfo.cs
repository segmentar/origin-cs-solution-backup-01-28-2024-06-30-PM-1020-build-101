using Core;

namespace Core
{
    using System;

    using System.IO;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class Bootxportableio
    {
        public static IList<FileInfo> BootxportableFileInfoSet(DirectoryInfo[] array_DIRECTORYINFO)
        {
            ICollection<FileInfo> collectionResult = default;

            collectionResult = new Collection<FileInfo>();

            foreach (DirectoryInfo value_DIRRECTORYINFO in array_DIRECTORYINFO)
            {
                var array = Directory.GetFiles(value_DIRRECTORYINFO.FullName);

                foreach (String stringValue in array)
                {
                    FileInfo fileInfo;

                    fileInfo = new FileInfo(stringValue);

                    collectionResult.Add(fileInfo);

                    continue;
                }

                continue;
            }

            return new List<FileInfo>(collectionResult);
        }

    }
}
