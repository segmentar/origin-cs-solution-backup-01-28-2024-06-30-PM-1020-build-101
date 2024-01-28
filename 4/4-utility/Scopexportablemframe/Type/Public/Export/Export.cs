using Core;

namespace Core
{
    using System;

    public partial struct Scopexportablemframe
    {
        public static Scopexportablemframe Export()
        {
            Scopexportablemframe scopexportablemframeResult;

            Scopexportablemframe scopexportablemframe;

            scopexportablemframe = new Scopexportablemframe();

            scopexportablemframe.LinkedListObject = LinkedList;

            scopexportablemframe.PointerObject = Pointer;

            scopexportablemframeResult = scopexportablemframe;

            return scopexportablemframeResult;
        }
    }
}
