using Core;

namespace Core
{
    using System;

    public partial struct Scopexportablemstate
    {
        public static void Import(Scopexportablemstate value_SCOPEXPORTABLEMSTATE)
        {
            IsRun = (Boolean)value_SCOPEXPORTABLEMSTATE.IsRunObject;

            IsPause = (Boolean)value_SCOPEXPORTABLEMSTATE.IsPauseObject;

            ShouldSkip = (Boolean)value_SCOPEXPORTABLEMSTATE.ShouldSkipObject;

            Interval = (Int32)value_SCOPEXPORTABLEMSTATE.IntervalObject;

            return;
        }
    }
}
