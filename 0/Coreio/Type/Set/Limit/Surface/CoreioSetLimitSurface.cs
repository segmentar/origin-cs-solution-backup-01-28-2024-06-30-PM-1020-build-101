using Core;

namespace Core
{
    using System;

    public partial class Coreio
    {
        public static String[] CoreioLimitSetSurface(String DirectoryFullName___VALUE, Boolean answer_SELF_should, Int32 Limit_VALUE)
        {
            String[] arrayResult = default;

            var list = CoreioLimitSet(DirectoryFullName___VALUE, answer_SELF_should, Limit_VALUE);

            var array = new String[list.Count];

            list.CopyTo(array, Corepolicy.IndexPolicy);

            arrayResult = array;

            return arrayResult;
        }
    }
}
