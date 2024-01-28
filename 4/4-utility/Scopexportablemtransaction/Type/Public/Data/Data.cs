using Core;

namespace Core
{
    using System;

    public partial struct Scopexportablemtransaction
    {
        public static Scopexportablemtransaction Data()
        {
            Scopexportablemtransaction scopexportablemonitortransactionResult = default;

            Scopexportablemtransaction scopexportablemonitortransaction;

            scopexportablemonitortransaction = new Scopexportablemtransaction();

            scopexportablemonitortransaction.Import();

            scopexportablemonitortransaction.Export();

            scopexportablemonitortransactionResult = scopexportablemonitortransaction;

            return scopexportablemonitortransactionResult;
        }
    }
}
