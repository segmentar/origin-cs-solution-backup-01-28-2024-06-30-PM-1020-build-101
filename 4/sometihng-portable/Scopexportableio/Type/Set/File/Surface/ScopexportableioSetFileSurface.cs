using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class Scopexportableio
    {
        public static FileInfo[] ScopexportableioFileSetSurface(String Directory_VALUE, Boolean answer_SELF_should)
        {
            FileInfo[] arrayResult = default;

            var list = ScopexportableioFileSet(Directory_VALUE, answer_SELF_should);

            var array = new FileInfo[list.Count];

            list.CopyTo(array, ScopexportablePolicy.ScopexportableIndexPolicy);

            arrayResult = array;

            return arrayResult;
        }
    }
}
