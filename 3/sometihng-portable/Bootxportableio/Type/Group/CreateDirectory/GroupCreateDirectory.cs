using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class Bootxportableio
    {
        public static DirectoryInfo GroupCreateDirectory(String DirectoryFullName__VALUE, Boolean answer_CREATE_should)
        {
            DirectoryInfo directoryInfoResult = default;

            var boolean = true;

            boolean = boolean && answer_CREATE_should is true;

            boolean = boolean && Directory.Exists(DirectoryFullName__VALUE) is false;

            Boolean isEqualCheck, shouldReturnCheck;

            isEqualCheck = boolean is true;

            shouldReturnCheck = isEqualCheck is false;

            DirectoryInfo directoryInfo;

            directoryInfo = new DirectoryInfo(DirectoryFullName__VALUE);

            if (shouldReturnCheck is true)
            {
                directoryInfoResult = directoryInfo;

                return directoryInfoResult;
            }
            else
                "false".ToString();

            directoryInfo = Directory.CreateDirectory(DirectoryFullName__VALUE);

            directoryInfoResult = directoryInfo;

            return directoryInfoResult;
        }
    }
}
