using Core;

namespace Core
{
    using System;

    public partial struct Scopexportablemstate
    {
        public static Scopexportablemstate Export()
        {
            Scopexportablemstate scopexportablemstateResult = default;

            Scopexportablemstate scopexportablemstate;

            scopexportablemstate = new Scopexportablemstate();

            scopexportablemstate.IsRunObject = IsRun;

            scopexportablemstate.IsPauseObject = IsPause;

            scopexportablemstate.ShouldSkipObject = ShouldSkip;

            scopexportablemstate.IntervalObject = Interval;

            scopexportablemstateResult = scopexportablemstate;

            return scopexportablemstateResult;
        }
    }
}
