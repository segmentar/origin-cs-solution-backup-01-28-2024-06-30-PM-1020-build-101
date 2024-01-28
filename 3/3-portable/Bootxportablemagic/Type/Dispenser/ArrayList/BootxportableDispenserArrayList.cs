using Core;

namespace Core
{
    using System;

    using System.Collections;

    public partial class Bootxportablemagic
    {
        public static ArrayList BootxportableArrayListDispenser(IEnumerable value_ENUMERABLE)
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
