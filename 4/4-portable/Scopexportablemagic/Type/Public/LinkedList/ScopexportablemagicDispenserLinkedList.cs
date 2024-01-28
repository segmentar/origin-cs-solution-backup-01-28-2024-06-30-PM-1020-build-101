using Core;

namespace Core
{
    using System;

    using System.Collections;
    using System.Collections.Generic;

    public partial class Scopexportablemagic
    {
        public static LinkedList<T> ScopexportablemagicLinkedListDispenser<T>(IEnumerable<T> value_ENUMERABLE)
        {
            LinkedList<T> listResult = default;

            LinkedList<T> linkedList;

            linkedList = new LinkedList<T>(value_ENUMERABLE);

            listResult = linkedList;

            return listResult;
        }
    }
}
