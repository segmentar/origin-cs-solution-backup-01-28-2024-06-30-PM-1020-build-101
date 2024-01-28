using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class Bootxportableio
    {
        public static DirectoryInfo[] FunctionDirectoryInfoSetSurface(String DirectoryFulLName___VALUE, Boolean answer_SELF_should, Boolean answer_FLAT_should)
        {
            DirectoryInfo[] arrayResult = default;

            var list = FunctionDirectoryInfoSet(DirectoryFulLName___VALUE, answer_SELF_should, answer_FLAT_should);

            var array = new DirectoryInfo[list.Count];

            list.CopyTo(array, BootxportablePolicy.BootxportableIndexPolicy);

            arrayResult = array;

            return arrayResult;
        }
        
    }
}
