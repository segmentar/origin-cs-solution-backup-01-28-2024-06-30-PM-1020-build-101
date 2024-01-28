using Core;

namespace Core
{
    using System;

    public partial struct Scopexportablemtransaction
    {
        public void Import()
        {
            Scopexportablemonitorstate = Scopexportablemstate.Export();

            Scopexportablemframe = Scopexportablemframe.Export();

            Scopexportablemonitorfilearray = Scopexportablemfilearray.Export();            

            return;
        }
    }
}
