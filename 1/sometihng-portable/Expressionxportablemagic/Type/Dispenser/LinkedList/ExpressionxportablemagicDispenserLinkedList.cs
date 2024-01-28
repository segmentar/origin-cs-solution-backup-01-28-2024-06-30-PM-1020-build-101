using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class Expressionxportablemagic
    {
        public static LinkedList<T> ExpressionxportablemagicLinkedListDispenser<T>(IEnumerable<T> value_ENUMERABLE)
        {
            LinkedList<T> listResult = default;

            LinkedList<T> linkedList;

            linkedList = new LinkedList<T>(value_ENUMERABLE);

            listResult = linkedList;

            return listResult;
        }
    }
}
