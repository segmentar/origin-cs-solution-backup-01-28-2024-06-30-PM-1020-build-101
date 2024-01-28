using Core;

namespace Core
{
    using System;

    public partial struct Scopexportablemframe
    {
        public static Scopexportablemframe Data()
        {
            Scopexportablemframe scopexportablemframeResult;

            Scopexportablemframe scopexportablemframe;

            scopexportablemframe = new Scopexportablemframe();

            scopexportablemframe.LinkedListObject = Scopexportablemagic.ScopexportablemagicLinkedListDispenser<Scopexportablemtransaction>(new Scopexportablemtransaction[0]);

            scopexportablemframe.PointerObject = 0;

            scopexportablemframeResult = scopexportablemframe;

            return scopexportablemframeResult;
        }
    }
}
