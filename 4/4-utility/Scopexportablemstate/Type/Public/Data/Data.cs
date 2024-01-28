using Core;

namespace Core
{
    using System;

    public partial struct Scopexportablemstate
    {
        public static Scopexportablemstate Data()
        {
            Scopexportablemstate scopexportablemstateResult = default;

            Scopexportablemstate scopexportablemstate;

            scopexportablemstate = new Scopexportablemstate();

            scopexportablemstate.IsRunObject = true;

            scopexportablemstate.IsPauseObject = true;

            scopexportablemstate.ShouldSkipObject = false;

            scopexportablemstate.IntervalObject = 200;

            scopexportablemstateResult = scopexportablemstate;

            return scopexportablemstateResult;
        }
    }
}
