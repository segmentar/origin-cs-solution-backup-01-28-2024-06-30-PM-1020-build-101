using Core;

namespace Core
{
    using System;

    using System.Linq;

    using System.Collections;

    public partial class Coregithub
    {
        public static T[] CoregithubRebaseContainerSurface<T>(String[] Filesystem_ARRAY, String Rebase_ITEM, String Rebase_ENTRY)
        {
            T[] arrayResult = default;

            var list = CoregithubRebaseContainer(Filesystem_ARRAY, Rebase_ITEM, Rebase_ENTRY);

            IEnumerable enumerable;

            enumerable = list;

            enumerable = enumerable.OfType<T>();

            enumerable = enumerable.Cast<T>().ToArray<T>();

            var reflect = (T[])(enumerable as Array);

            var result = reflect;

            arrayResult = result;

            return arrayResult;
        }
    }
}
