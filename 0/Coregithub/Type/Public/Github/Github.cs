using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class Coregithub
    {
        public static void Github(String DirectoryFullName___ITEM, String DirectoryFullName___ENTRY)
        {
            var item = CoregithubSetResourceFullSurface(DirectoryFullName___ITEM);

            var entry = CoregithubRebaseContainerSurface<Tuple<String, String>>(item, DirectoryFullName___ITEM, DirectoryFullName___ENTRY);

            foreach (Tuple<String, String> value in entry)
            {
                if (Directory.Exists(value.Item1) is true)
                {
                    DirectoryInfo directoryInfo;

                    directoryInfo = Directory.CreateDirectory(value.Item2);
                }
                else
                    "false".ToString();

                if (File.Exists(value.Item1) is true)
                {
                    File.Copy(value.Item1, value.Item2, true);
                }
                else
                    "false".ToString();

                continue;
            }

            return;
        }
    }
}
