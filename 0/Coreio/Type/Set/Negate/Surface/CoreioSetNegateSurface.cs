using Core;

namespace Core
{
    using System;

    public partial class Coreio
    {
        public static String[] CoreioNegateSetSurface(String[] Filesystem_ARRAY, String Negate_VALUE)
        {
            String[] arrayResult = default;

            var list = CoreioNegateSet(Filesystem_ARRAY, Negate_VALUE);

            var array = new String[list.Count];

            list.CopyTo(array, Corepolicy.IndexPolicy);

            arrayResult = array;

            return arrayResult;
        }
    }
}
