using Core;

namespace Core
{
    using System;

    public partial class Scopexportableskip
    {
        public static void Skip()
        {
            Scopexportablemstate.ShouldSkip = Scopexportablemstate.ShouldSkip.Equals(false);

            return;
        }
    }
}
