using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class Materialxportableio
    {
        public static DirectoryInfo[] FunctionFolderSetSurface(String Directory_VALUE, Boolean answer_SELF_should)
        {
            DirectoryInfo[] arrayResult = default;

            var list = FunctionFolderSet(Directory_VALUE, answer_SELF_should);

            var array = new DirectoryInfo[list.Count];

            list.CopyTo(array, MaterialxportablePolicy.MaterialxportableIndexPolicy);

            arrayResult = array;

            return arrayResult;
        }
    }
}
