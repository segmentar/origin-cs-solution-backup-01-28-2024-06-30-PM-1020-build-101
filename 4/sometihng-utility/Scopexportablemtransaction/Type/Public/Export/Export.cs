using Core;

namespace Core
{
    using System;

    public partial struct Scopexportablemtransaction
    {
        public void Export()
        {
            Scopexportablemstate.Import(Scopexportablemonitorstate);

            Scopexportablemframe.Import(Scopexportablemframe);

            Scopexportablemfilearray.Import(Scopexportablemonitorfilearray);

            return;
        }
    }
}
