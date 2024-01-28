using Core;

namespace Core
{
    using System;

    public partial class Scopexportablepause
    {
        public static void Pause()
        {
            Scopexportablemstate.IsPause = Scopexportablemstate.IsPause.Equals(false);

            return;
        }
    }
}
