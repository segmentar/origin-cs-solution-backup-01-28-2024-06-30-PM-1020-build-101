using Core;

namespace Core
{
    using System;

    using System.Collections;

    public partial class Integerxportablemagic
    {
        public static ArrayList IntegerxportablemagicArrayListDispenser(IEnumerable value_ENUMERABLE)
        {
            ArrayList listResult = default;

            var reflect = (ICollection)(value_ENUMERABLE as IEnumerable);

            ArrayList arrayList;

            arrayList = new ArrayList(reflect);

            listResult = arrayList;

            return listResult;
        }
    }
}
