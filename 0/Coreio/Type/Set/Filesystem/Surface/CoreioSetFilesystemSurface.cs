using Core;

namespace Core
{
    using System;

    public partial class Coreio
    {
        public static String[] CoreioFilesystemSetSurface(String DirectoryFullName___VALUE, Boolean answer_SELF_should)
        {
            String[] arrayResult = default;

            var list = CoreioFilesystemSet(DirectoryFullName___VALUE, answer_SELF_should);

            var array = new String[list.Count];

            list.CopyTo(array, Corepolicy.IndexPolicy);

            arrayResult = array;

            return arrayResult;
        }
    }
}
