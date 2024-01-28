using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class Bootxportablefolder
    {
        public static String Folder(Boolean answer_CREATE_should)
        {
            String stringResult = default;

            var CurrentDirectory__VALUE = Directory.GetCurrentDirectory();

            var path_DIRECTORY_full_name = Path.Combine(CurrentDirectory__VALUE, Bootxportablename.EntityFolderName);

            var boolean = true;

            boolean = boolean && answer_CREATE_should is true;

            boolean = boolean && Directory.Exists(path_DIRECTORY_full_name) is false;

            Boolean isEqualCheck;

            isEqualCheck = boolean is true;

            if (isEqualCheck is true)
            {
                DirectoryInfo directoryInfo;

                directoryInfo = Directory.CreateDirectory(path_DIRECTORY_full_name);

                path_DIRECTORY_full_name = directoryInfo.FullName;
            }
            else
                "false".ToString();

            var result = path_DIRECTORY_full_name;

            stringResult = result;

            return stringResult;
        }
    }
}
