using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class Integerxportableincrement
    {
        public static Boolean ForgeIncrementRecurse()
        {
            Boolean booleanResult = default;

            var character = Integerxportable.Character();

            var value = IncrementBase(character);

            Boolean boolean;

            boolean = true;

            boolean = boolean && Object.Equals(Integerxportableascii.EntityZero, (Int32)value) is true;

            if (boolean is true)
            {
                var node = Interop.InteropLinkedListNodeCastDispenser<Object>(Integerxportable.Node());

                node.Value = value;
            }
            else
                "false".ToString();

            if (boolean is true)
            {
                booleanResult = true;
            }
            else
                "false".ToString();

            return booleanResult;
        }
    }
}
