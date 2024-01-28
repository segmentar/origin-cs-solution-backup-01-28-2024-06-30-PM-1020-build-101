using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class Scopexportableio
    {
        public static FileInfo[] CurrentDirectoryFolderFileArray(String FolderName__VALUE, Boolean answer_SELF_should)
        {
            FileInfo[] arrayResult = default;

            var CurrentDirectory_PATH = Directory.GetCurrentDirectory();

            var path_DIRECTORY_full_name = Path.Combine(CurrentDirectory_PATH, FolderName__VALUE);

            if (Directory.Exists(path_DIRECTORY_full_name) is false)
            {
                DirectoryInfo directoryInfo;

                directoryInfo = Directory.CreateDirectory(path_DIRECTORY_full_name);

                path_DIRECTORY_full_name = directoryInfo.FullName;
            }
            else
                "false".ToString();

            var array = ScopexportableioFileSetSurface(path_DIRECTORY_full_name, answer_SELF_should);

            arrayResult = array;

            return arrayResult;
        }
    }
}
