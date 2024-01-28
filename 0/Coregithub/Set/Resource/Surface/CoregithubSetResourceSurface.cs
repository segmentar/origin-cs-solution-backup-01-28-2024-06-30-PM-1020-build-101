using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class Coregithub
    {
        
        public static DirectoryInfo[] CoregithubSetResourceSurface(String[] DirectoryFullName___ARRAY)
        {
            DirectoryInfo[] arrayResult = default;

            var list = CoregithubSetResource(DirectoryFullName___ARRAY);

            var array = new DirectoryInfo[list.Count];

            list.CopyTo(array, Corepolicy.IndexPolicy);

            arrayResult = array;

            return arrayResult;
        }
    }
}
