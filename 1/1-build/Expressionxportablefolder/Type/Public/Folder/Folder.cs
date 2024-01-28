using Core;

namespace Core
{
    using System;

    using System.IO;

    using System.Reflection;

    public partial class Expressionxportablefolder
    {
        public static DirectoryInfo Folder()
        {
            DirectoryInfo directoryInfoResult = default;

            var EntryAssembly__PATH = Assembly.GetEntryAssembly().Location;

            var path = EntryAssembly__PATH;

            path = Path.GetDirectoryName(EntryAssembly__PATH);

            path = Path.Combine(Expressionxportablestoreextension.EntityFolderName);

            var path_DIRECTORY_full_name = path;

            DirectoryInfo directoryInfo;

            directoryInfo = new DirectoryInfo(path_DIRECTORY_full_name);

            directoryInfoResult = directoryInfo;

            return directoryInfoResult;
        }
    }
}
