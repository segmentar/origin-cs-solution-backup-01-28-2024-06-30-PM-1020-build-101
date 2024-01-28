using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class Coreio
    {
        public static FileInfo[] CoreioFileSetSurface(String DirectoryFullName___VALUE, Boolean answer_SELF_should)
        {
            FileInfo[] arrayResult = default;

            var list = CoreioFileSet(DirectoryFullName___VALUE, answer_SELF_should);

            var array = new FileInfo[list.Count];

            list.CopyTo(array, Corepolicy.IndexPolicy);

            arrayResult = array;
            
            return arrayResult;
        }
    }
}
