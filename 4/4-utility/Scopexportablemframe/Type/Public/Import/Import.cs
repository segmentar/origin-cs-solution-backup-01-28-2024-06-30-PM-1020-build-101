using Core;

namespace Core
{
    using System;

    public partial struct Scopexportablemframe
    {
        public static void Import(Scopexportablemframe value_SCOPEXPORTABLEMFRAME)
        {
            LinkedList = Scopexportablemagic.ScopexportablemagicLinkedListCastDispenser<Scopexportablemtransaction>(value_SCOPEXPORTABLEMFRAME.LinkedListObject);

            Pointer = (Int32)value_SCOPEXPORTABLEMFRAME.PointerObject;
            
            return;
        }
    }
}
