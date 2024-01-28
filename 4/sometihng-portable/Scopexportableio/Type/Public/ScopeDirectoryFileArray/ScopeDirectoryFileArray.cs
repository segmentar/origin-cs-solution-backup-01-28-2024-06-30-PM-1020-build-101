using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class Scopexportableio
    {
        public static FileInfo[] ScopeDirectoryFileArray(Boolean answer_SELF_should)
        {
            FileInfo[] arrayResult = default;

            arrayResult = CurrentDirectoryFolderFileArray(Scopexportablename.EntityScopeFolderName, answer_SELF_should);

            return arrayResult;
        }
    }
}
