using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class Bootxportableio
    {
        public static FileInfo[] BootxportableFileInfoSetSurface(DirectoryInfo[] array_DIRECTORYINFO)
        {
            FileInfo[] arrayResult = default;

            var list = BootxportableFileInfoSet(array_DIRECTORYINFO);

            var array = new FileInfo[list.Count];

            list.CopyTo(array, BootxportablePolicy.BootxportableIndexPolicy);

            arrayResult = array;

            return arrayResult;
        }
    }
}
