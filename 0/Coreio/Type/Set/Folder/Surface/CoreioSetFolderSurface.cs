using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class Coreio
    {
        public static DirectoryInfo[] CoreioFolderSetSurface(String DirectoryFullName___VALUE, Boolean answer_SELF_should)
        {
            DirectoryInfo[] arrayResult = default;

            var list = CoreioFolderSet(DirectoryFullName___VALUE, answer_SELF_should);

            var array = new DirectoryInfo[list.Count];

            list.CopyTo(array, Corepolicy.IndexPolicy);

            arrayResult = array;

            return arrayResult;
        }
    }
}
