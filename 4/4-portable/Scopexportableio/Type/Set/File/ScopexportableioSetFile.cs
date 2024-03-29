﻿using Core;

namespace Core
{
    using System;

    using System.IO;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class Scopexportableio
    {
        public static IList<FileInfo> ScopexportableioFileSet(String Directory_VALUE, Boolean answer_SELF_should)
        {
            ICollection<FileInfo> collectionResult = default;

            collectionResult = new Collection<FileInfo>();

            var item = ScopexportableioFolderSetSurface(Directory_VALUE, answer_SELF_should);

            foreach (DirectoryInfo directoryInfo in item)
            {
                var entry = Directory.GetFiles(directoryInfo.FullName);

                foreach (String stringValue in entry)
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
