using Core;

namespace Core
{
    using System;

    public partial struct Scopexportablemframe
    {
        [Scopexportableism]
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] { 
            
                String.Empty + nameof(Scopexportablemframe) + ' ' + "::" + ' ' + '{',
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(LinkedListObject) + ':' + ' ' + ". . ." + ' ' + $"<{Scopexportablemagic.ScopexportablemagicLinkedListCastDispenser<Scopexportablemtransaction>(LinkedListObject).Count}>",
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(PointerObject) + ':' + ' ' + (Int32)PointerObject,
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(LinkedListObject) + ':',
                String.Empty + String.Join('\n'.ToString(), Scopexportablemagic.ScopexportablemagicLinkedListCastDispenser<Scopexportablemtransaction>(LinkedListObject))
            });
        }
    }
}
