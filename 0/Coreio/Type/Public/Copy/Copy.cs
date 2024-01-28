using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class Coreio
    {
        public static void Copy(String DirectoryFullName___ITEM, String DirectoryFullName___ENTRY, String DirectoryFullName___VALUE, String DirectoryFullName___RESULT)
        {
            var item = CoreioFilesystemSetSurface(DirectoryFullName___RESULT, true);

            var entry = CoreioNegateSetSurface(item, DirectoryFullName___ITEM);

            Console.Out.WriteLine($"[{DirectoryFullName___RESULT}]");

            foreach (String stringValue in entry)
            {
                var path = String.Empty;

                path = Path.Combine(path, DirectoryFullName___ENTRY);

                path = Path.Combine(path, stringValue);

                Console.Out.WriteLine($"final path [{path}]");

                continue;
            }


            return;
        }
    }
}
