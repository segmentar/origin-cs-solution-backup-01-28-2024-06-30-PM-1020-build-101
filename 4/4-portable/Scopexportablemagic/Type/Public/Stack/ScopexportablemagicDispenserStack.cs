using Core;

namespace Core
{
    using System;

    using System.Collections;

    public partial class Scopexportablemagic
    {
        public static Stack ScopexportablemagicStackDispenser(IEnumerable value_ENUMERABLE)
        {
            Stack stackResult = default;

            var reflect = (ICollection)(value_ENUMERABLE as IEnumerable);

            Stack stack;

            stack = new Stack(reflect);

            stackResult = stack;

            return stackResult;
        }
    }
}
