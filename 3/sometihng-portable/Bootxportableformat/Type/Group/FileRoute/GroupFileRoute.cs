using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class Bootxportableformat
    {
        public static String GroupFileRoute(String DirectoryFullName___VALUE, Int32 Ordinal_VALUE)
        {
            String stringResult = default;

            var format = String.Format("{0} {1}", Ordinal_VALUE, Path.GetRandomFileName());

            var path_FILE_filename = Path.Combine(DirectoryFullName___VALUE, format);

            var path_FILE_filename_with_extension = Path.ChangeExtension(path_FILE_filename, "txt");

            var result = path_FILE_filename_with_extension;

            stringResult = result;

            return stringResult;
        }
    }
}
