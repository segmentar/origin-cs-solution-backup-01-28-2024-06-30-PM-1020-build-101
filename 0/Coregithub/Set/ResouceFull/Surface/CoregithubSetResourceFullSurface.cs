using Core;

namespace Core
{
    using System;

    public partial class Coregithub
    {

        public static String[] CoregithubSetResourceFullSurface(String DirectoryFullName___VALUE)
        {
            String[] arrayResult = default;

            var list = CoregithubSetResourceFull(DirectoryFullName___VALUE);

            var array = new String[list.Count];

            list.CopyTo(array, Corepolicy.IndexPolicy);

            arrayResult = array;

            return arrayResult;
        }
    }
}
